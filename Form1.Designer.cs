namespace LibraryDatabase
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.rbGood = new System.Windows.Forms.RadioButton();
            this.rbFair = new System.Windows.Forms.RadioButton();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.gbAvailable = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.gbDetails1 = new System.Windows.Forms.GroupBox();
            this.rbHardCover = new System.Windows.Forms.RadioButton();
            this.rbPaperback = new System.Windows.Forms.RadioButton();
            this.lbCover = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbMag = new System.Windows.Forms.RadioButton();
            this.rbEbook = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.gbDetails2 = new System.Windows.Forms.GroupBox();
            this.tbSlot3 = new System.Windows.Forms.TextBox();
            this.tbSlot2 = new System.Windows.Forms.TextBox();
            this.tbSlot1 = new System.Windows.Forms.TextBox();
            this.lbSlot3 = new System.Windows.Forms.Label();
            this.lbSlot2 = new System.Windows.Forms.Label();
            this.lbSlot1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.ListboxAlerts = new System.Windows.Forms.ListBox();
            this.gbCondition.SuspendLayout();
            this.gbAvailable.SuspendLayout();
            this.gbDetails1.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbDetails2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(28, 73);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(146, 44);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title:";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAuthor
            // 
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(28, 129);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(146, 63);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Author:";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGenre
            // 
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(28, 194);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(146, 63);
            this.lbGenre.TabIndex = 2;
            this.lbGenre.Text = "Genre:";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(159, 70);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(529, 38);
            this.tbTitle.TabIndex = 5;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.Location = new System.Drawing.Point(159, 136);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(529, 38);
            this.tbAuthor.TabIndex = 6;
            // 
            // tbGenre
            // 
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.Location = new System.Drawing.Point(159, 201);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(6);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(529, 38);
            this.tbGenre.TabIndex = 7;
            // 
            // rbGood
            // 
            this.rbGood.AutoSize = true;
            this.rbGood.Location = new System.Drawing.Point(82, 42);
            this.rbGood.Margin = new System.Windows.Forms.Padding(6);
            this.rbGood.Name = "rbGood";
            this.rbGood.Size = new System.Drawing.Size(111, 35);
            this.rbGood.TabIndex = 8;
            this.rbGood.TabStop = true;
            this.rbGood.Text = "Good";
            this.rbGood.UseVisualStyleBackColor = true;
            this.rbGood.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbFair
            // 
            this.rbFair.AutoSize = true;
            this.rbFair.Location = new System.Drawing.Point(244, 42);
            this.rbFair.Margin = new System.Windows.Forms.Padding(6);
            this.rbFair.Name = "rbFair";
            this.rbFair.Size = new System.Drawing.Size(92, 35);
            this.rbFair.TabIndex = 9;
            this.rbFair.TabStop = true;
            this.rbFair.Text = "Fair";
            this.rbFair.UseVisualStyleBackColor = true;
            this.rbFair.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.rbFair);
            this.gbCondition.Controls.Add(this.rbGood);
            this.gbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCondition.Location = new System.Drawing.Point(608, 31);
            this.gbCondition.Margin = new System.Windows.Forms.Padding(6);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Padding = new System.Windows.Forms.Padding(6);
            this.gbCondition.Size = new System.Drawing.Size(420, 102);
            this.gbCondition.TabIndex = 10;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "Condition:";
            // 
            // gbAvailable
            // 
            this.gbAvailable.Controls.Add(this.rbNo);
            this.gbAvailable.Controls.Add(this.rbYes);
            this.gbAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailable.Location = new System.Drawing.Point(1028, 31);
            this.gbAvailable.Margin = new System.Windows.Forms.Padding(6);
            this.gbAvailable.Name = "gbAvailable";
            this.gbAvailable.Padding = new System.Windows.Forms.Padding(6);
            this.gbAvailable.Size = new System.Drawing.Size(450, 102);
            this.gbAvailable.TabIndex = 11;
            this.gbAvailable.TabStop = false;
            this.gbAvailable.Text = "Available:";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(260, 42);
            this.rbNo.Margin = new System.Windows.Forms.Padding(6);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(80, 35);
            this.rbNo.TabIndex = 10;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(114, 42);
            this.rbYes.Margin = new System.Windows.Forms.Padding(6);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(92, 35);
            this.rbYes.TabIndex = 8;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // gbDetails1
            // 
            this.gbDetails1.Controls.Add(this.rbHardCover);
            this.gbDetails1.Controls.Add(this.rbPaperback);
            this.gbDetails1.Controls.Add(this.lbCover);
            this.gbDetails1.Controls.Add(this.tbGenre);
            this.gbDetails1.Controls.Add(this.tbAuthor);
            this.gbDetails1.Controls.Add(this.tbTitle);
            this.gbDetails1.Controls.Add(this.lbGenre);
            this.gbDetails1.Controls.Add(this.lbAuthor);
            this.gbDetails1.Controls.Add(this.lbTitle);
            this.gbDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails1.Location = new System.Drawing.Point(89, 142);
            this.gbDetails1.Name = "gbDetails1";
            this.gbDetails1.Size = new System.Drawing.Size(715, 359);
            this.gbDetails1.TabIndex = 12;
            this.gbDetails1.TabStop = false;
            this.gbDetails1.Text = "Details:";
            // 
            // rbHardCover
            // 
            this.rbHardCover.AutoSize = true;
            this.rbHardCover.Location = new System.Drawing.Point(400, 271);
            this.rbHardCover.Margin = new System.Windows.Forms.Padding(6);
            this.rbHardCover.Name = "rbHardCover";
            this.rbHardCover.Size = new System.Drawing.Size(184, 35);
            this.rbHardCover.TabIndex = 12;
            this.rbHardCover.TabStop = true;
            this.rbHardCover.Text = "Hard Cover";
            this.rbHardCover.UseVisualStyleBackColor = true;
            this.rbHardCover.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbPaperback
            // 
            this.rbPaperback.AutoSize = true;
            this.rbPaperback.Location = new System.Drawing.Point(158, 271);
            this.rbPaperback.Margin = new System.Windows.Forms.Padding(6);
            this.rbPaperback.Name = "rbPaperback";
            this.rbPaperback.Size = new System.Drawing.Size(175, 35);
            this.rbPaperback.TabIndex = 11;
            this.rbPaperback.TabStop = true;
            this.rbPaperback.Text = "Paperback";
            this.rbPaperback.UseVisualStyleBackColor = true;
            this.rbPaperback.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbCover
            // 
            this.lbCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCover.Location = new System.Drawing.Point(28, 257);
            this.lbCover.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCover.Name = "lbCover";
            this.lbCover.Size = new System.Drawing.Size(146, 63);
            this.lbCover.TabIndex = 8;
            this.lbCover.Text = "Cover:";
            this.lbCover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbMag);
            this.gbType.Controls.Add(this.rbEbook);
            this.gbType.Controls.Add(this.rbBook);
            this.gbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbType.Location = new System.Drawing.Point(89, 31);
            this.gbType.Margin = new System.Windows.Forms.Padding(6);
            this.gbType.Name = "gbType";
            this.gbType.Padding = new System.Windows.Forms.Padding(6);
            this.gbType.Size = new System.Drawing.Size(517, 102);
            this.gbType.TabIndex = 13;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type:";
            // 
            // rbMag
            // 
            this.rbMag.AutoSize = true;
            this.rbMag.Location = new System.Drawing.Point(334, 42);
            this.rbMag.Margin = new System.Windows.Forms.Padding(6);
            this.rbMag.Name = "rbMag";
            this.rbMag.Size = new System.Drawing.Size(162, 35);
            this.rbMag.TabIndex = 10;
            this.rbMag.TabStop = true;
            this.rbMag.Text = "Magazine";
            this.rbMag.UseVisualStyleBackColor = true;
            this.rbMag.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbEbook
            // 
            this.rbEbook.AutoSize = true;
            this.rbEbook.Location = new System.Drawing.Point(179, 43);
            this.rbEbook.Margin = new System.Windows.Forms.Padding(6);
            this.rbEbook.Name = "rbEbook";
            this.rbEbook.Size = new System.Drawing.Size(125, 35);
            this.rbEbook.TabIndex = 9;
            this.rbEbook.TabStop = true;
            this.rbEbook.Text = "EBook";
            this.rbEbook.UseVisualStyleBackColor = true;
            this.rbEbook.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(43, 42);
            this.rbBook.Margin = new System.Windows.Forms.Padding(6);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(107, 35);
            this.rbBook.TabIndex = 8;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // gbDetails2
            // 
            this.gbDetails2.Controls.Add(this.tbSlot3);
            this.gbDetails2.Controls.Add(this.tbSlot2);
            this.gbDetails2.Controls.Add(this.tbSlot1);
            this.gbDetails2.Controls.Add(this.lbSlot3);
            this.gbDetails2.Controls.Add(this.lbSlot2);
            this.gbDetails2.Controls.Add(this.lbSlot1);
            this.gbDetails2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails2.Location = new System.Drawing.Point(89, 521);
            this.gbDetails2.Name = "gbDetails2";
            this.gbDetails2.Size = new System.Drawing.Size(715, 299);
            this.gbDetails2.TabIndex = 13;
            this.gbDetails2.TabStop = false;
            this.gbDetails2.Text = "Additional Info:";
            // 
            // tbSlot3
            // 
            this.tbSlot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlot3.Location = new System.Drawing.Point(257, 194);
            this.tbSlot3.Margin = new System.Windows.Forms.Padding(6);
            this.tbSlot3.Name = "tbSlot3";
            this.tbSlot3.Size = new System.Drawing.Size(431, 38);
            this.tbSlot3.TabIndex = 7;
            // 
            // tbSlot2
            // 
            this.tbSlot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlot2.Location = new System.Drawing.Point(257, 129);
            this.tbSlot2.Margin = new System.Windows.Forms.Padding(6);
            this.tbSlot2.Name = "tbSlot2";
            this.tbSlot2.Size = new System.Drawing.Size(431, 38);
            this.tbSlot2.TabIndex = 6;
            // 
            // tbSlot1
            // 
            this.tbSlot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlot1.Location = new System.Drawing.Point(257, 63);
            this.tbSlot1.Margin = new System.Windows.Forms.Padding(6);
            this.tbSlot1.Name = "tbSlot1";
            this.tbSlot1.Size = new System.Drawing.Size(431, 38);
            this.tbSlot1.TabIndex = 5;
            // 
            // lbSlot3
            // 
            this.lbSlot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlot3.Location = new System.Drawing.Point(28, 194);
            this.lbSlot3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSlot3.Name = "lbSlot3";
            this.lbSlot3.Size = new System.Drawing.Size(270, 63);
            this.lbSlot3.TabIndex = 2;
            this.lbSlot3.Text = "Issue Month:";
            // 
            // lbSlot2
            // 
            this.lbSlot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlot2.Location = new System.Drawing.Point(28, 129);
            this.lbSlot2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSlot2.Name = "lbSlot2";
            this.lbSlot2.Size = new System.Drawing.Size(270, 63);
            this.lbSlot2.TabIndex = 1;
            this.lbSlot2.Text = "Narrator Name:";
            // 
            // lbSlot1
            // 
            this.lbSlot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlot1.Location = new System.Drawing.Point(28, 73);
            this.lbSlot1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSlot1.Name = "lbSlot1";
            this.lbSlot1.Size = new System.Drawing.Size(270, 44);
            this.lbSlot1.TabIndex = 0;
            this.lbSlot1.Text = "Audio Length:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(982, 682);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 64);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClose.Location = new System.Drawing.Point(1187, 682);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(192, 64);
            this.btnSaveClose.TabIndex = 15;
            this.btnSaveClose.Text = "Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // ListboxAlerts
            // 
            this.ListboxAlerts.FormattingEnabled = true;
            this.ListboxAlerts.ItemHeight = 25;
            this.ListboxAlerts.Location = new System.Drawing.Point(852, 162);
            this.ListboxAlerts.Name = "ListboxAlerts";
            this.ListboxAlerts.Size = new System.Drawing.Size(626, 479);
            this.ListboxAlerts.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 865);
            this.Controls.Add(this.ListboxAlerts);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbDetails2);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.gbDetails1);
            this.Controls.Add(this.gbAvailable);
            this.Controls.Add(this.gbCondition);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Library Records";
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            this.gbAvailable.ResumeLayout(false);
            this.gbAvailable.PerformLayout();
            this.gbDetails1.ResumeLayout(false);
            this.gbDetails1.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbDetails2.ResumeLayout(false);
            this.gbDetails2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.RadioButton rbGood;
        private System.Windows.Forms.RadioButton rbFair;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.GroupBox gbAvailable;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.GroupBox gbDetails1;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbMag;
        private System.Windows.Forms.RadioButton rbEbook;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.GroupBox gbDetails2;
        private System.Windows.Forms.TextBox tbSlot3;
        private System.Windows.Forms.TextBox tbSlot2;
        private System.Windows.Forms.TextBox tbSlot1;
        private System.Windows.Forms.Label lbSlot3;
        private System.Windows.Forms.Label lbSlot2;
        private System.Windows.Forms.Label lbSlot1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Label lbCover;
        private System.Windows.Forms.RadioButton rbHardCover;
        private System.Windows.Forms.RadioButton rbPaperback;
        private System.Windows.Forms.ListBox ListboxAlerts;
    }
}

