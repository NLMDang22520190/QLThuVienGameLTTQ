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
        private const string connectionString = "DefaultEndpointsProtocol=https;AccountName=gamesdata;AccountKey=+o4CkMa2drN/78K4nMuSwpp11HMU9r+3Wv5fmLOnKq/wOt3CXTSF+Z8PgRLVnyxoXO6tQabL403z+AStDdx0dg==;EndpointSuffix=core.windows.net";
        private string extractFolder;

        public inventoryForm(Account currentUserAccount)
        {
            InitializeComponent();
            this.currentUserAccount = currentUserAccount;

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
            if (sender is Button clickedButton)
            {
                // Lấy tên game từ Button và thay đổi PictureBox tương ứng
                string gameName = clickedButton.Text;
                ChangePictureBoxByGameName(gameName);
            }
            if (installBtn.Visible == false)
            {
                installBtn.Visible = true;
            }
            if (uninstallBtn.Visible == false)
            {
                uninstallBtn.Visible = true;
            }
            if (downloadProgressBar.Visible == false)
            {
                downloadProgressBar.Visible = true;
            }
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
            //this.installBtn.Text = "Install";
        }
        private void ChangeInstallBtnStyleToPlay()
        {
            this.installBtn.ForeColor = Color.LimeGreen;
            this.installBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.installBtn.IconColor = Color.LimeGreen;
            //this.installBtn.Text = "Install";
        }

        private bool CheckInstallBtnText()
        {
            if (installBtn.Text == "Install")
                return true;
            else
                return false;
        }

        private async void InstallGame()
        {
            DialogResult result = MessageBox.Show("Do you want to choose your download path", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string destinationFilePath;
                // Mở SaveFileDialog để chọn nơi lưu trữ dữ liệu tải về
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "ZIP Files (*.zip)|*.zip";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        destinationFilePath = saveFileDialog.FileName;

                        // Thực hiện tải dữ liệu từ Blob Storage
                        await DownloadBlobAsync("tesing1", "Endoparasitic.zip", destinationFilePath);

                        // Giải nén file ZIP
                        extractFolder = Path.Combine(Path.GetDirectoryName(destinationFilePath), Path.GetFileNameWithoutExtension(destinationFilePath));
                        ExtractZipFile(destinationFilePath, extractFolder);

                        // Xoá file ZIP sau khi giải nén
                        File.Delete(destinationFilePath);
                    }
                }
            }
            else
            {

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
                            downloadProgressBar.Value = progressPercentage;
                        }
                    }
                }

                MessageBox.Show("Download completed!");
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

        private void PlayGame()
        {
            try
            {
                // Tên của tệp batch bạn muốn chạy
                string batchFileName = "__Start game + create shortcut.bat";

                // Đường dẫn đầy đủ đến tệp batch sau khi giải nén
                string batchFilePath = Path.Combine(extractFolder, batchFileName);

                // Kiểm tra xem tệp batch có tồn tại không
                if (File.Exists(batchFilePath))
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
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp batch.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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

            if (CheckInstallBtnText())
                ChangeInstallBtnStyleToInstall();
            else
                ChangeInstallBtnStyleToPlay();

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


        private void installBtn_Click(object sender, EventArgs e)
        {
            if (CheckInstallBtnText())
            {
                InstallGame();
                installBtn.Text = "Play";
                ChangeInstallBtnStyleToPlay() ;
            }
            else
                PlayGame();
        }
    }
}
