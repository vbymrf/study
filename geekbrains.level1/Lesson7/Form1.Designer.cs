using System.Collections.Generic;

namespace Lesson7
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.lblDoublerInfo = new System.Windows.Forms.Label();
            this.lblDoubler = new System.Windows.Forms.Label();
            this.lblFinishInfo = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(137, 12);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(137, 44);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(137, 120);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(13, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(137, 73);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Отмена";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(12, 106);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(71, 44);
            this.btnGame.TabIndex = 5;
            this.btnGame.Text = "Играть";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // lblDoublerInfo
            // 
            this.lblDoublerInfo.AutoSize = true;
            this.lblDoublerInfo.Location = new System.Drawing.Point(13, 50);
            this.lblDoublerInfo.Name = "lblDoublerInfo";
            this.lblDoublerInfo.Size = new System.Drawing.Size(64, 13);
            this.lblDoublerInfo.TabIndex = 6;
            this.lblDoublerInfo.Text = "Попытка  =";
            // 
            // lblDoubler
            // 
            this.lblDoubler.AutoSize = true;
            this.lblDoubler.Location = new System.Drawing.Point(80, 50);
            this.lblDoubler.Name = "lblDoubler";
            this.lblDoubler.Size = new System.Drawing.Size(13, 13);
            this.lblDoubler.TabIndex = 7;
            this.lblDoubler.Text = "0";
            // 
            // lblFinishInfo
            // 
            this.lblFinishInfo.AutoSize = true;
            this.lblFinishInfo.Location = new System.Drawing.Point(12, 83);
            this.lblFinishInfo.Name = "lblFinishInfo";
            this.lblFinishInfo.Size = new System.Drawing.Size(56, 13);
            this.lblFinishInfo.TabIndex = 8;
            this.lblFinishInfo.Text = "Финиш  =";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(83, 83);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(13, 13);
            this.lblFinish.TabIndex = 9;
            this.lblFinish.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 162);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblFinishInfo);
            this.Controls.Add(this.lblDoubler);
            this.Controls.Add(this.lblDoublerInfo);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Back.Push(Doubler.NowNumber);

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Label lblDoublerInfo;
        private System.Windows.Forms.Label lblDoubler;
        private System.Windows.Forms.Label lblFinishInfo;
        private System.Windows.Forms.Label lblFinish;

        private System.Collections.Generic.Stack<int> Back = new Stack<int>();

    }
}