using System.Windows.Forms;

namespace DijkstraAlg
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStartingField = new System.Windows.Forms.Button();
            this.buttonObstacle = new System.Windows.Forms.Button();
            this.buttonEndingField = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 286);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(56, 31);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(148, 33);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start finding path";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStartingField
            // 
            this.buttonStartingField.Location = new System.Drawing.Point(232, 31);
            this.buttonStartingField.Name = "buttonStartingField";
            this.buttonStartingField.Size = new System.Drawing.Size(138, 33);
            this.buttonStartingField.TabIndex = 2;
            this.buttonStartingField.Text = "Strating field";
            this.buttonStartingField.UseVisualStyleBackColor = true;
            this.buttonStartingField.Click += new System.EventHandler(this.buttonStartingField_Click);
            // 
            // buttonObstacle
            // 
            this.buttonObstacle.Location = new System.Drawing.Point(395, 31);
            this.buttonObstacle.Name = "buttonObstacle";
            this.buttonObstacle.Size = new System.Drawing.Size(147, 33);
            this.buttonObstacle.TabIndex = 3;
            this.buttonObstacle.Text = "Obstacle";
            this.buttonObstacle.UseVisualStyleBackColor = true;
            this.buttonObstacle.Click += new System.EventHandler(this.buttonObstacle_Click);
            // 
            // buttonEndingField
            // 
            this.buttonEndingField.Location = new System.Drawing.Point(232, 71);
            this.buttonEndingField.Name = "buttonEndingField";
            this.buttonEndingField.Size = new System.Drawing.Size(138, 30);
            this.buttonEndingField.TabIndex = 4;
            this.buttonEndingField.Text = "Ending field";
            this.buttonEndingField.UseVisualStyleBackColor = true;
            this.buttonEndingField.Click += new System.EventHandler(this.buttonEndingField_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(56, 71);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(148, 30);
            this.reloadButton.TabIndex = 5;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.buttonEndingField);
            this.Controls.Add(this.buttonObstacle);
            this.Controls.Add(this.buttonStartingField);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonStart;
        private Button buttonStartingField;
        private Button buttonObstacle;
        private Button buttonEndingField;
        private Button reloadButton;
    }
}

