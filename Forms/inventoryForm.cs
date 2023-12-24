using Azure.Storage.Blobs;
using EpistWinform.DAO;
using EpistWinform.DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpistWinform.Forms
{
    public partial class inventoryForm : Form
    {
        private List<Game> gameList;
        private Account currentUserAccount;
        private Game currentChoosenGame;
        private Game currentInstallingGame;
        private Game currentPlayingGame;
        private const string connectionString = "DefaultEndpointsProtocol=https;AccountName=gamedatalttq;AccountKey=D8SYJRzwjmzZt04xBKbZWIP/dKdrDpWUKoTCfqUmzSUhYhX7h6ueLNOLH+aXQm0LIEyhHZqtq4BU+AStCzOf0g==;EndpointSuffix=core.windows.net";
        private string extractFolder;
        private string saveGamePath = "./Download/Path/";
        private string defaultSaveGameFolder = "./Download/Game/";
        private bool isDownloading = false;
        private bool isPlaying = false;
        private Thread playGameThread;


        public inventoryForm(Account currentUserAccount)
        {
            InitializeComponent();
            this.currentUserAccount = currentUserAccount;
            if(!Directory.Exists(saveGamePath))
            {
                Directory.CreateDirectory(saveGamePath);
            }
            if(!Directory.Exists(defaultSaveGameFolder))
            {
                Directory.CreateDirectory(defaultSaveGameFolder);
            }

        }
        #region method
        private void LoadGameList()
        {
            gameList = GamesDAO.Instance.LoadOwnGamesList(currentUserAccount.UserID);
            foreach (Game game in gameList)
            {
                Button gameBtn = new Button() { Margin = new Padding(10, 0, 10, 0) };
                gameBtn.Width = ownGameLayoutPanel.Width - gameBtn.Margin.Left - gameBtn.Margin.Right;
                gameBtn.AutoSize = true;
                gameBtn.Text = game.GameName;
                gameBtn.TextAlign = ContentAlignment.MiddleCenter;
                gameBtn.Font = new Font("Tahoma", 10);
                gameBtn.ForeColor = Color.White;
                gameBtn.Click += GameButton_Click;
                ownGameLayoutPanel.Controls.Add(gameBtn);
            }

        }

        private void FilterButtons(string keyword)
        {
            foreach (Control control in ownGameLayoutPanel.Controls)
            {
                if (control is Button button)
                {
                    // Kiểm tra xem tên của button có chứa từ khóa không
                    bool isVisible = button.Text.ToLower().Contains(keyword.ToLower());
                    button.Visible = isVisible;
                }
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            string gameName = "";
            if (sender is Button clickedButton)
            {
                // Lấy tên game từ Button và thay đổi PictureBox tương ứng
                gameName = clickedButton.Text;
                ChangePictureBoxByGameName(gameName);
            }
            if (installBtn.Visible == false)
            {
                installBtn.Visible = true;
            }
            if(installPanel.Visible == false)
            {
                installPanel.Visible = true;
            }

            if (CheckIfGameHasDownloaded() == false)
            {
                if (currentInstallingGame != null)
                {
                    if (currentInstallingGame.GameName == gameName && isDownloading == true)
                    {
                        ChangeInstallBtnToInstalling();
                    }
                    else
                        ChangeInstallBtnStyleToInstall();
                }

                else
                    ChangeInstallBtnStyleToInstall();
            }
            else
                ChangeInstallBtnStyleToPlay();

        }

        private void ChangePictureBoxByGameName(string gameName)
        {
            string bannerPath = "";
            foreach (Game game in gameList)
            {
                if (game.GameName == gameName)
                {
                    currentChoosenGame = game;
                    bannerPath = game.Picture1;
                    break;
                }

            }
            bannerPictureBox.Image = Image.FromFile(bannerPath);
        }

        private void ChangeInstallBtnStyleToInstall()
        {
            this.installBtn.ForeColor = Color.DodgerBlue;
            this.installBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.installBtn.IconColor = Color.DodgerBlue;
            this.installBtn.Text = "Install";
            this.uninstallBtn.Visible = false;
            this.downloadProgressBar.Visible = false;
        }
        private void ChangeInstallBtnStyleToPlay()
        {
            this.installBtn.ForeColor = Color.LimeGreen;
            this.installBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.installBtn.IconColor = Color.LimeGreen;
            this.installBtn.Text = "Play";
            this.uninstallBtn.Visible = true;
            this.downloadProgressBar.Visible = false;

        }

        private void ChangeInstallBtnToInstalling()
        {
            this.installBtn.Enabled = false; // Chuyển sang trạng thái không kích hoạt
            this.installBtn.Text = "Installing";
            this.installBtn.IconChar = IconChar.None;
            this.uninstallBtn.Visible = false;
            this.downloadProgressBar.Visible = true;
            //installBtn.BackColor = Color.Gray; // Thay đổi màu sắc nền (hoặc thay đổi kiểu hiển thị khác)
        }

        private bool CheckInstallBtnText()
        {
            if (installBtn.Text == "Install")
                return true;
            else
                return false;
        }

        private async Task InstallGame()
        {
            DialogResult result = MessageBox.Show("Do you want to choose your own download path ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string destinationFilePath;
                string defaultFileName = $"{currentInstallingGame.GameName}.zip";

                try
                {
                    //ChangeInstallBtnToInstalling();
                    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                    {
                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            string destinationFolderPath = folderBrowserDialog.SelectedPath;

                            // Tạo đường dẫn đầy đủ cho file dựa trên đường dẫn thư mục và tên file mặc định
                            destinationFilePath = Path.Combine(destinationFolderPath, defaultFileName);

                            // Thực hiện tải dữ liệu từ Blob Storage
                            await Task.Run(() => DownloadBlobAsync("gamefiledata", defaultFileName, destinationFilePath));

                            // Giải nén file ZIP
                            extractFolder = Path.Combine(destinationFolderPath, Path.GetFileNameWithoutExtension(destinationFilePath));
                            ExtractZipFile(destinationFilePath, extractFolder);

                            // Xoá file ZIP sau khi giải nén
                            File.Delete(destinationFilePath);
                        }
                    }

                }
                catch (Exception)
                {
                    //MessageBox.Show("Download error!!!");
                    ChangeInstallBtnStyleToInstall();
                }

            }
            else
            {
                string defaultFolderPath = defaultSaveGameFolder;
                string destinationFilePath = Path.Combine(defaultFolderPath, $"{currentInstallingGame.GameName}.zip");

                try
                {
                    await Task.Run(() => DownloadBlobAsync("gamefiledata", $"{currentInstallingGame.GameName}.zip", destinationFilePath));
                    extractFolder = Path.Combine(defaultFolderPath, Path.GetFileNameWithoutExtension(destinationFilePath));
                    ExtractZipFile(destinationFilePath, extractFolder);
                    File.Delete(destinationFilePath);
                }
                catch (Exception)
                {
                    ChangeInstallBtnStyleToInstall();
                }
            }
        }

        private async Task DownloadBlobAsync(string containerName, string blobName, string destinationFilePath)
        {
            try
            {
                var blobServiceClient = new BlobServiceClient(connectionString);
                var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
                var blobClient = containerClient.GetBlobClient(blobName);

                var response = await blobClient.DownloadAsync();

                // Lấy kích thước dữ liệu để theo dõi tiến độ
                long totalBytes = response.Value.ContentLength;
                long bytesRead = 0;

                // Ghi dữ liệu từ stream vào file đích và cập nhật thanh progress bar
                using (var fs = File.OpenWrite(destinationFilePath))
                {
                    using (var stream = response.Value.Content)
                    {
                        byte[] buffer = new byte[8192];
                        int bytesReadThisTime;

                        while ((bytesReadThisTime = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            fs.Write(buffer, 0, bytesReadThisTime);
                            bytesRead += bytesReadThisTime;

                            // Tính toán và cập nhật giá trị của progress bar
                            int progressPercentage = (int)((double)bytesRead / totalBytes * 100);
                            Invoke((MethodInvoker)delegate
                            {
                                downloadProgressBar.Value = progressPercentage;
                            });
                            //downloadProgressBar.Value = progressPercentage;
                        }
                    }

                }


                MessageBox.Show("Download completed!", "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ExtractZipFile(string zipFilePath, string extractFolder)
        {
            // Tạo thư mục để giải nén nếu chưa tồn tại
            if (!Directory.Exists(extractFolder))
            {
                Directory.CreateDirectory(extractFolder);
            }

            // Giải nén file ZIP
            ZipFile.ExtractToDirectory(zipFilePath, extractFolder);
        }

        //private async Task PlayGame()
        //{
        //    try
        //    {
        //        isPlaying = true;
        //        string saveGameFileInTxt = saveGamePath + $"{currentChoosenGame.GameName}" + ".txt";
        //        string currentGameExtractFolder = "";

        //        using (StreamReader sr = new StreamReader(saveGameFileInTxt))
        //        {
        //            currentGameExtractFolder = sr.ReadLine();
        //        }

        //        // Tên của tệp batch bạn muốn chạy
        //        string batchFileName = "__Start game + create shortcut.bat";

        //        // Đường dẫn đầy đủ đến tệp batch sau khi giải nén
        //        string batchFilePath = Path.Combine(currentGameExtractFolder, batchFileName);

        //        // Kiểm tra xem tệp batch có tồn tại không
        //        if (File.Exists(batchFilePath))
        //        {
        //            // Định cấu hình cho quá trình
        //            ProcessStartInfo processStartInfo = new ProcessStartInfo
        //            {
        //                FileName = "cmd.exe",  // Sử dụng Command Prompt để thực hiện tệp batch
        //                Arguments = $"/c \"{batchFilePath}\"",  // /c để chạy và đóng Command Prompt sau khi hoàn thành
        //                RedirectStandardOutput = true,
        //                RedirectStandardError = true,
        //                UseShellExecute = false,
        //                CreateNoWindow = true
        //            };

        //            // Thực hiện quá trình và đọc kết quả đầu ra (nếu cần)
        //            using (Process process = new Process { StartInfo = processStartInfo })
        //            {
        //                process.Start();
        //                string output = process.StandardOutput.ReadToEnd();
        //                string error = process.StandardError.ReadToEnd();
        //                process.WaitForExit();

        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không tìm thấy tệp batch.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //    finally
        //    { isPlaying = false; }
        //}
        private void PlayGame()
        {
            try
            {
                isPlaying = true; // Bắt đầu chơi game

                string saveGameFileInTxt = saveGamePath + $"{currentChoosenGame.GameName}" + ".txt";
                string currentGameExtractFolder = "";

                using (StreamReader sr = new StreamReader(saveGameFileInTxt))
                {
                    currentGameExtractFolder = sr.ReadLine();
                }

                // Tên của tệp batch bạn muốn chạy
                string batchFileName = "__Start game + create shortcut.bat";

                // Đường dẫn đầy đủ đến tệp batch sau khi giải nén
                string batchFilePath = Path.Combine(currentGameExtractFolder, batchFileName);

                // Kiểm tra xem tệp batch có tồn tại không
                if (File.Exists(batchFilePath))
                {
                    // Tạo luồng mới để chạy quá trình chơi game
                    playGameThread = new Thread(() =>
                    {
                        // Định cấu hình cho quá trình
                        ProcessStartInfo processStartInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",  // Sử dụng Command Prompt để thực hiện tệp batch
                            Arguments = $"/c \"{batchFilePath}\"",  // /c để chạy và đóng Command Prompt sau khi hoàn thành
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        // Thực hiện quá trình và đọc kết quả đầu ra (nếu cần)
                        using (Process process = new Process { StartInfo = processStartInfo })
                        {
                            process.Start();
                            string output = process.StandardOutput.ReadToEnd();
                            string error = process.StandardError.ReadToEnd();
                            process.WaitForExit();
                        }

                        // Kết thúc chơi game
                        isPlaying = false;
                    });

                    // Bắt đầu luồng
                    playGameThread.Start();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp batch.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

                // Kết thúc chơi game (trong trường hợp có lỗi)
                isPlaying = false;
            }
        }

        private void SaveInstallGamePath()
        {
            string saveGameFileInTxt = saveGamePath + $"{currentInstallingGame.GameName}" + ".txt";
            using (StreamWriter sw = new StreamWriter(saveGameFileInTxt, true))
            {
                sw.WriteLine(extractFolder);
            }
        }

        private bool CheckIfGameHasDownloaded()
        {
            string saveGameFileInTxt = saveGamePath + $"{currentChoosenGame.GameName}" + ".txt";

            if (File.Exists(saveGameFileInTxt))
                return true;
            else
                return false;

        }
        #endregion

        #region events
        private void inventoryForm_Load(object sender, EventArgs e)
        {
            searchLabel.Width = ownGameLayoutPanel.Width;
            searchTextBox.Margin = new Padding(10, 0, 10, 0);
            searchTextBox.Width = ownGameLayoutPanel.Width - searchTextBox.Margin.Left - searchTextBox.Margin.Right;

            installBtn.Visible = false;
            uninstallBtn.Visible = false;
            downloadProgressBar.Visible = false;
            installPanel.Visible = false;

            //if (CheckInstallBtnText())
            //    ChangeInstallBtnStyleToInstall();
            //else
            //    ChangeInstallBtnStyleToPlay();

            LoadGameList();


        }

        private void inventoryForm_Resize(object sender, EventArgs e)
        {
            bannerPictureBox.Height = ownGameLayoutPanel.Height / 2;
        }

        private void inventoryForm_SizeChanged(object sender, EventArgs e)
        {


        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterButtons(searchTextBox.Text);
        }

        #endregion


        private async void installBtn_Click(object sender, EventArgs e)
        {
            if (isDownloading || isPlaying)
            {
                // Nếu đang tải xuống, không làm gì khi click nút
                MessageBox.Show("Another Game is installing or Playing, please wait.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckInstallBtnText())
            {
                try
                {
                    downloadProgressBar.Visible = true;
                    isDownloading = true;
                    currentInstallingGame = currentChoosenGame;

                    // Đặt trạng thái nút là "Installing"
                    ChangeInstallBtnToInstalling();

                    await InstallGame();

                    // Sau khi cài đặt xong, chuyển trạng thái nút và giao diện
                    if (currentChoosenGame.GameName == currentInstallingGame.GameName)
                        ChangeInstallBtnStyleToPlay();
                    SaveInstallGamePath();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    installBtn.Enabled = true; // Kích hoạt lại nút
                    downloadProgressBar.Visible = false;
                    isDownloading = false;
                }
            }
            else
            {
                currentPlayingGame = currentChoosenGame;
                PlayGame();
            }

        }

        private void uninstallBtn_Click(object sender, EventArgs e)
        {
            if(isPlaying && currentChoosenGame.GameName == currentPlayingGame.GameName)
            {
                MessageBox.Show("Please exit the game before uninstalling!", "Warnings", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }
            string saveGameFileInTxt = saveGamePath + $"{currentChoosenGame.GameName}" + ".txt";
            string currentGameExtractFolder = "";

            using (StreamReader sr = new StreamReader(saveGameFileInTxt))
            {
                currentGameExtractFolder = sr.ReadLine();
            }

            // Yêu cầu xác nhận trước khi xóa thư mục của game
            DialogResult result = MessageBox.Show("Are you sure you want to uninstall the game?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Directory.Exists(currentGameExtractFolder))
                    {
                        Directory.Delete(currentGameExtractFolder, true); // Xóa thư mục và tất cả các tệp con
                    }

                    File.Delete(saveGameFileInTxt);
                    ChangeInstallBtnStyleToInstall();
                    MessageBox.Show("Uninstall completed!", "Uninstall Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during uninstallation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
