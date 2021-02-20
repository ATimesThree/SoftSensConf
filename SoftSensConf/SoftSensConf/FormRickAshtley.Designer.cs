
namespace SoftSensConf
{
    partial class FormRickAshtley
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRickAshtley));
            this.buttonRickAshleyConfirm = new System.Windows.Forms.Button();
            this.buttonRickAshleyCancel = new System.Windows.Forms.Button();
            this.textBoxRickAshley = new System.Windows.Forms.TextBox();
            this.labelRickAshleyTop = new System.Windows.Forms.Label();
            this.labelRickAshleyBottom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerConnectivity = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRickAshleyConfirm
            // 
            this.buttonRickAshleyConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonRickAshleyConfirm.FlatAppearance.BorderSize = 0;
            this.buttonRickAshleyConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRickAshleyConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRickAshleyConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonRickAshleyConfirm.Location = new System.Drawing.Point(138, 213);
            this.buttonRickAshleyConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRickAshleyConfirm.Name = "buttonRickAshleyConfirm";
            this.buttonRickAshleyConfirm.Size = new System.Drawing.Size(92, 28);
            this.buttonRickAshleyConfirm.TabIndex = 1;
            this.buttonRickAshleyConfirm.Text = "Confirm";
            this.buttonRickAshleyConfirm.UseVisualStyleBackColor = false;
            this.buttonRickAshleyConfirm.Click += new System.EventHandler(this.buttonRickAshleyConfirm_Click);
            // 
            // buttonRickAshleyCancel
            // 
            this.buttonRickAshleyCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonRickAshleyCancel.FlatAppearance.BorderSize = 0;
            this.buttonRickAshleyCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRickAshleyCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRickAshleyCancel.ForeColor = System.Drawing.Color.White;
            this.buttonRickAshleyCancel.Location = new System.Drawing.Point(238, 213);
            this.buttonRickAshleyCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRickAshleyCancel.Name = "buttonRickAshleyCancel";
            this.buttonRickAshleyCancel.Size = new System.Drawing.Size(92, 28);
            this.buttonRickAshleyCancel.TabIndex = 2;
            this.buttonRickAshleyCancel.Text = "Cancel";
            this.buttonRickAshleyCancel.UseVisualStyleBackColor = false;
            this.buttonRickAshleyCancel.Click += new System.EventHandler(this.buttonRickAshleyCancel_Click);
            // 
            // textBoxRickAshley
            // 
            this.textBoxRickAshley.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxRickAshley.Location = new System.Drawing.Point(85, 174);
            this.textBoxRickAshley.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRickAshley.MaxLength = 8;
            this.textBoxRickAshley.Name = "textBoxRickAshley";
            this.textBoxRickAshley.PasswordChar = '*';
            this.textBoxRickAshley.Size = new System.Drawing.Size(161, 22);
            this.textBoxRickAshley.TabIndex = 0;
            this.textBoxRickAshley.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRickAshley.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRickAshley_KeyDown);
            // 
            // labelRickAshleyTop
            // 
            this.labelRickAshleyTop.AutoSize = true;
            this.labelRickAshleyTop.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelRickAshleyTop.Location = new System.Drawing.Point(35, 7);
            this.labelRickAshleyTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRickAshleyTop.Name = "labelRickAshleyTop";
            this.labelRickAshleyTop.Size = new System.Drawing.Size(270, 25);
            this.labelRickAshleyTop.TabIndex = 3;
            this.labelRickAshleyTop.Text = "Please enter device password";
            // 
            // labelRickAshleyBottom
            // 
            this.labelRickAshleyBottom.AutoSize = true;
            this.labelRickAshleyBottom.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelRickAshleyBottom.Location = new System.Drawing.Point(43, 38);
            this.labelRickAshleyBottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRickAshleyBottom.Name = "labelRickAshleyBottom";
            this.labelRickAshleyBottom.Size = new System.Drawing.Size(260, 25);
            this.labelRickAshleyBottom.TabIndex = 4;
            this.labelRickAshleyBottom.Text = "to update the configuration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timerConnectivity
            // 
            this.timerConnectivity.Enabled = true;
            this.timerConnectivity.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRickAshtley
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(343, 254);
            this.Controls.Add(this.labelRickAshleyBottom);
            this.Controls.Add(this.labelRickAshleyTop);
            this.Controls.Add(this.textBoxRickAshley);
            this.Controls.Add(this.buttonRickAshleyCancel);
            this.Controls.Add(this.buttonRickAshleyConfirm);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRickAshtley";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Required!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRickAshleyConfirm;
        private System.Windows.Forms.Button buttonRickAshleyCancel;
        private System.Windows.Forms.TextBox textBoxRickAshley;
        private System.Windows.Forms.Label labelRickAshleyTop;
        private System.Windows.Forms.Label labelRickAshleyBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerConnectivity;
    }
}