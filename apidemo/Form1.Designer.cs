
namespace apidemo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.comicImage = new System.Windows.Forms.PictureBox();
            this.btnComicLoader = new System.Windows.Forms.Button();
            this.txbxComicNumberEnttry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.comicImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(331, 25);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 30);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(437, 25);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comicImage
            // 
            this.comicImage.ImageLocation = "";
            this.comicImage.Location = new System.Drawing.Point(12, 81);
            this.comicImage.Name = "comicImage";
            this.comicImage.Size = new System.Drawing.Size(0, 0);
            this.comicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.comicImage.TabIndex = 3;
            this.comicImage.TabStop = false;
            // 
            // btnComicLoader
            // 
            this.btnComicLoader.Location = new System.Drawing.Point(225, 25);
            this.btnComicLoader.Name = "btnComicLoader";
            this.btnComicLoader.Size = new System.Drawing.Size(100, 30);
            this.btnComicLoader.TabIndex = 1;
            this.btnComicLoader.Text = "Load Comic";
            this.btnComicLoader.UseVisualStyleBackColor = true;
            this.btnComicLoader.Click += new System.EventHandler(this.btnComicLoader_ClickAsync);
            // 
            // txbxComicNumberEnttry
            // 
            this.txbxComicNumberEnttry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxComicNumberEnttry.Location = new System.Drawing.Point(119, 29);
            this.txbxComicNumberEnttry.MaximumSize = new System.Drawing.Size(200, 200);
            this.txbxComicNumberEnttry.MaxLength = 6;
            this.txbxComicNumberEnttry.Name = "txbxComicNumberEnttry";
            this.txbxComicNumberEnttry.Size = new System.Drawing.Size(100, 26);
            this.txbxComicNumberEnttry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comic Number:";
            // 
            // mainPicBox
            // 
            this.mainPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPicBox.Location = new System.Drawing.Point(12, 81);
            this.mainPicBox.Name = "mainPicBox";
            this.mainPicBox.Size = new System.Drawing.Size(525, 437);
            this.mainPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPicBox.TabIndex = 5;
            this.mainPicBox.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 531);
            this.Controls.Add(this.mainPicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxComicNumberEnttry);
            this.Controls.Add(this.btnComicLoader);
            this.Controls.Add(this.comicImage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.comicImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox comicImage;
        private System.Windows.Forms.Button btnComicLoader;
        private System.Windows.Forms.TextBox txbxComicNumberEnttry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainPicBox;
    }
}

