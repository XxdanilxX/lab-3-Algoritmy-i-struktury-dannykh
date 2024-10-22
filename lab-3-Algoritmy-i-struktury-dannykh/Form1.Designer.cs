namespace lab_3_Algoritmy_i_struktury_dannykh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageQueue = new TabPage();
            lblQueueOutput = new Label();
            btnRemoveNegatives = new Button();
            btnCreateQueue = new Button();
            txtQueueInput = new TextBox();
            label1 = new Label();
            tabPageStacks = new TabPage();
            lblStackOutputL = new Label();
            lblStackOutputL2 = new Label();
            lblStackOutputL1 = new Label();
            btnMergeStacks = new Button();
            btnCreateStacks = new Button();
            txtStackInput2 = new TextBox();
            txtStackInput1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPageQueue.SuspendLayout();
            tabPageStacks.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageQueue);
            tabControl1.Controls.Add(tabPageStacks);
            tabControl1.Location = new Point(16, 18);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(480, 365);
            tabControl1.TabIndex = 0;
            // 
            // tabPageQueue
            // 
            tabPageQueue.Controls.Add(lblQueueOutput);
            tabPageQueue.Controls.Add(btnRemoveNegatives);
            tabPageQueue.Controls.Add(btnCreateQueue);
            tabPageQueue.Controls.Add(txtQueueInput);
            tabPageQueue.Controls.Add(label1);
            tabPageQueue.Location = new Point(4, 29);
            tabPageQueue.Margin = new Padding(4, 5, 4, 5);
            tabPageQueue.Name = "tabPageQueue";
            tabPageQueue.Padding = new Padding(4, 5, 4, 5);
            tabPageQueue.Size = new Size(472, 332);
            tabPageQueue.TabIndex = 0;
            tabPageQueue.Text = "Черга";
            tabPageQueue.UseVisualStyleBackColor = true;
            // 
            // lblQueueOutput
            // 
            lblQueueOutput.AutoSize = true;
            lblQueueOutput.Location = new Point(31, 188);
            lblQueueOutput.Margin = new Padding(4, 0, 4, 0);
            lblQueueOutput.Name = "lblQueueOutput";
            lblQueueOutput.Size = new Size(0, 20);
            lblQueueOutput.TabIndex = 4;
            // 
            // btnRemoveNegatives
            // 
            btnRemoveNegatives.Location = new Point(276, 114);
            btnRemoveNegatives.Margin = new Padding(4, 5, 4, 5);
            btnRemoveNegatives.Name = "btnRemoveNegatives";
            btnRemoveNegatives.Size = new Size(148, 35);
            btnRemoveNegatives.TabIndex = 3;
            btnRemoveNegatives.Text = "Видалити негативні";
            btnRemoveNegatives.UseVisualStyleBackColor = true;
            btnRemoveNegatives.Click += btnRemoveNegatives_Click;
            // 
            // btnCreateQueue
            // 
            btnCreateQueue.Location = new Point(276, 51);
            btnCreateQueue.Margin = new Padding(4, 5, 4, 5);
            btnCreateQueue.Name = "btnCreateQueue";
            btnCreateQueue.Size = new Size(148, 35);
            btnCreateQueue.TabIndex = 2;
            btnCreateQueue.Text = "Створити чергу";
            btnCreateQueue.UseVisualStyleBackColor = true;
            btnCreateQueue.Click += btnCreateQueue_Click;
            // 
            // txtQueueInput
            // 
            txtQueueInput.Location = new Point(35, 55);
            txtQueueInput.Margin = new Padding(4, 5, 4, 5);
            txtQueueInput.Name = "txtQueueInput";
            txtQueueInput.Size = new Size(215, 27);
            txtQueueInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть числа через пробіл:";
            // 
            // tabPageStacks
            // 
            tabPageStacks.Controls.Add(lblStackOutputL);
            tabPageStacks.Controls.Add(lblStackOutputL2);
            tabPageStacks.Controls.Add(lblStackOutputL1);
            tabPageStacks.Controls.Add(btnMergeStacks);
            tabPageStacks.Controls.Add(btnCreateStacks);
            tabPageStacks.Controls.Add(txtStackInput2);
            tabPageStacks.Controls.Add(txtStackInput1);
            tabPageStacks.Controls.Add(label2);
            tabPageStacks.Controls.Add(label3);
            tabPageStacks.Location = new Point(4, 29);
            tabPageStacks.Margin = new Padding(4, 5, 4, 5);
            tabPageStacks.Name = "tabPageStacks";
            tabPageStacks.Padding = new Padding(4, 5, 4, 5);
            tabPageStacks.Size = new Size(472, 332);
            tabPageStacks.TabIndex = 1;
            tabPageStacks.Text = "Стеки";
            tabPageStacks.UseVisualStyleBackColor = true;
            // 
            // lblStackOutputL
            // 
            lblStackOutputL.AutoSize = true;
            lblStackOutputL.Location = new Point(31, 232);
            lblStackOutputL.Margin = new Padding(4, 0, 4, 0);
            lblStackOutputL.Name = "lblStackOutputL";
            lblStackOutputL.Size = new Size(57, 20);
            lblStackOutputL.TabIndex = 9;
            lblStackOutputL.Text = "Стек L: ";
            // 
            // lblStackOutputL2
            // 
            lblStackOutputL2.AutoSize = true;
            lblStackOutputL2.Location = new Point(31, 183);
            lblStackOutputL2.Margin = new Padding(4, 0, 4, 0);
            lblStackOutputL2.Name = "lblStackOutputL2";
            lblStackOutputL2.Size = new Size(65, 20);
            lblStackOutputL2.TabIndex = 8;
            lblStackOutputL2.Text = "Стек L2: ";
            // 
            // lblStackOutputL1
            // 
            lblStackOutputL1.AutoSize = true;
            lblStackOutputL1.Location = new Point(31, 131);
            lblStackOutputL1.Margin = new Padding(4, 0, 4, 0);
            lblStackOutputL1.Name = "lblStackOutputL1";
            lblStackOutputL1.Size = new Size(65, 20);
            lblStackOutputL1.TabIndex = 7;
            lblStackOutputL1.Text = "Стек L1: ";
            // 
            // btnMergeStacks
            // 
            btnMergeStacks.Location = new Point(303, 86);
            btnMergeStacks.Margin = new Padding(4, 5, 4, 5);
            btnMergeStacks.Name = "btnMergeStacks";
            btnMergeStacks.Size = new Size(148, 35);
            btnMergeStacks.TabIndex = 6;
            btnMergeStacks.Text = "Об'єднати стеки";
            btnMergeStacks.UseVisualStyleBackColor = true;
            btnMergeStacks.Click += btnMergeStacks_Click;
            // 
            // btnCreateStacks
            // 
            btnCreateStacks.Location = new Point(303, 31);
            btnCreateStacks.Margin = new Padding(4, 5, 4, 5);
            btnCreateStacks.Name = "btnCreateStacks";
            btnCreateStacks.Size = new Size(148, 35);
            btnCreateStacks.TabIndex = 5;
            btnCreateStacks.Text = "Створити стеки";
            btnCreateStacks.UseVisualStyleBackColor = true;
            btnCreateStacks.Click += btnCreateStacks_Click;
            // 
            // txtStackInput2
            // 
            txtStackInput2.Location = new Point(35, 89);
            txtStackInput2.Margin = new Padding(4, 5, 4, 5);
            txtStackInput2.Name = "txtStackInput2";
            txtStackInput2.Size = new Size(215, 27);
            txtStackInput2.TabIndex = 4;
            // 
            // txtStackInput1
            // 
            txtStackInput1.Location = new Point(35, 34);
            txtStackInput1.Margin = new Padding(4, 5, 4, 5);
            txtStackInput1.Name = "txtStackInput1";
            txtStackInput1.Size = new Size(215, 27);
            txtStackInput1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "Елементи стека L1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Елементи стека L2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 402);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Стек і Черга";
            tabControl1.ResumeLayout(false);
            tabPageQueue.ResumeLayout(false);
            tabPageQueue.PerformLayout();
            tabPageStacks.ResumeLayout(false);
            tabPageStacks.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageQueue;
        private System.Windows.Forms.TabPage tabPageStacks;
        private System.Windows.Forms.Label lblQueueOutput;
        private System.Windows.Forms.Button btnRemoveNegatives;
        private System.Windows.Forms.Button btnCreateQueue;
        private System.Windows.Forms.TextBox txtQueueInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStackOutputL;
        private System.Windows.Forms.Label lblStackOutputL2;
        private System.Windows.Forms.Label lblStackOutputL1;
        private System.Windows.Forms.Button btnMergeStacks;
        private System.Windows.Forms.Button btnCreateStacks;
        private System.Windows.Forms.TextBox txtStackInput2;
        private System.Windows.Forms.TextBox txtStackInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}
