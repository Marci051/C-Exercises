namespace Me_
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
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.zoominButton = new System.Windows.Forms.Button();
            this.zoomoutButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topButton = new System.Windows.Forms.Button();
            this.bottomButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(39, 351);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(169, 351);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // zoominButton
            // 
            this.zoominButton.Location = new System.Drawing.Point(273, 363);
            this.zoominButton.Name = "zoominButton";
            this.zoominButton.Size = new System.Drawing.Size(75, 23);
            this.zoominButton.TabIndex = 3;
            this.zoominButton.Text = "Zoom In";
            this.zoominButton.UseVisualStyleBackColor = true;
            this.zoominButton.Click += new System.EventHandler(this.zoominButton_Click);
            // 
            // zoomoutButton
            // 
            this.zoomoutButton.Location = new System.Drawing.Point(379, 363);
            this.zoomoutButton.Name = "zoomoutButton";
            this.zoomoutButton.Size = new System.Drawing.Size(75, 23);
            this.zoomoutButton.TabIndex = 4;
            this.zoomoutButton.Text = "Zoom Out";
            this.zoomoutButton.UseVisualStyleBackColor = true;
            this.zoomoutButton.Click += new System.EventHandler(this.zoomoutButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(494, 363);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Change Pic";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Me_.Properties.Resources.lastOfUs3;
            this.pictureBox1.Location = new System.Drawing.Point(199, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // topButton
            // 
            this.topButton.Location = new System.Drawing.Point(169, 380);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(75, 23);
            this.topButton.TabIndex = 7;
            this.topButton.Text = "Top";
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.topButton_Click);
            // 
            // bottomButton
            // 
            this.bottomButton.Location = new System.Drawing.Point(39, 380);
            this.bottomButton.Name = "bottomButton";
            this.bottomButton.Size = new System.Drawing.Size(75, 23);
            this.bottomButton.TabIndex = 6;
            this.bottomButton.Text = "Bottom";
            this.bottomButton.UseVisualStyleBackColor = true;
            this.bottomButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topButton);
            this.Controls.Add(this.bottomButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.zoomoutButton);
            this.Controls.Add(this.zoominButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button zoominButton;
        private System.Windows.Forms.Button zoomoutButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Button bottomButton;
        private System.Windows.Forms.Button button1;
    }
}

