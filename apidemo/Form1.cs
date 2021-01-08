using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace apidemo
{
    public partial class frmMain : Form
    {
        private int maxNum = 0;
        private int minNum = 1;
        private int currentNum = 0;
        public frmMain()
        {
            InitializeComponent();
            APIHelper.InitializeCLient();
        }

        private async Task LoadImage(int imageNum)
        {
            var comic = await ComicProcessor.LoadComic(imageNum);
           
            if(imageNum == 0)
            {
                maxNum = comic.num;
            }
            currentNum = comic.num;

            string url = comic.img;
            mainPicBox.ImageLocation = url;
        }

        private async void btnComicLoader_ClickAsync(object sender, EventArgs e)
        {
            Validator.Validator validator = new Validator.Validator();
            if (validator.isWholeNumber(txbxComicNumberEnttry.Text) == true)
            {
                currentNum = Convert.ToInt32(txbxComicNumberEnttry.Text);
                await LoadImage(currentNum);
            }
            else
            {
                MessageBox.Show("Enter a whole number");
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (maxNum == currentNum)
            {           
                if (MessageBox.Show("Error, this is the most current comic\nWould you like to start at the beginning agian?",
                    "On Last Comic", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await LoadImage(1);
                    txbxComicNumberEnttry.Text = currentNum.ToString();
                }
                else
                {
                    await LoadImage(currentNum);                 
                    txbxComicNumberEnttry.Text = currentNum.ToString();
                }
            }
            else
            {
                await LoadImage(currentNum + 1);
                txbxComicNumberEnttry.Text = currentNum.ToString();
            }
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (minNum == currentNum)
            {
                if (MessageBox.Show("This is Comic #1\nWould you like to move to #2?",
                      "On Last Comic", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await LoadImage(currentNum + 1);
                    txbxComicNumberEnttry.Text = currentNum.ToString();
                }
                else
                {
                    await LoadImage(currentNum);
                    txbxComicNumberEnttry.Text = currentNum.ToString();
                }
            }
            else
            {
                await LoadImage(currentNum - 1);

                txbxComicNumberEnttry.Text = currentNum.ToString();
            }
        }
    }
}
