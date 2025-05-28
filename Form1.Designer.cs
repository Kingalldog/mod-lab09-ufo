namespace mod_lab09_ufo;

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
        boxX1 = new TextBox();
        boxX2 = new TextBox();
        button1 = new Button();
        boxY1 = new TextBox();
        boxY2 = new TextBox();
        button2 = new Button();
        button3 = new Button();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // boxX1
        // 
        boxX1.Location = new Point(23, 12);
        boxX1.Name = "boxX1";
        boxX1.Size = new Size(150, 31);
        boxX1.TabIndex = 0;
        // 
        // boxX2
        // 
        boxX2.Location = new Point(212, 12);
        boxX2.Name = "boxX2";
        boxX2.Size = new Size(150, 31);
        boxX2.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new Point(427, 10);
        button1.Name = "button1";
        button1.Size = new Size(112, 34);
        button1.TabIndex = 2;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // boxY1
        // 
        boxY1.Location = new Point(23, 60);
        boxY1.Name = "boxY1";
        boxY1.Size = new Size(150, 31);
        boxY1.TabIndex = 3;
        // 
        // boxY2
        // 
        boxY2.Location = new Point(212, 60);
        boxY2.Name = "boxY2";
        boxY2.Size = new Size(150, 31);
        boxY2.TabIndex = 4;
        // 
        // button2
        // 
        button2.Location = new Point(427, 60);
        button2.Name = "button2";
        button2.Size = new Size(112, 34);
        button2.TabIndex = 5;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(603, 26);
        button3.Name = "button3";
        button3.Size = new Size(185, 65);
        button3.TabIndex = 6;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(623, 113);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(150, 31);
        textBox1.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBox1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(boxY2);
        Controls.Add(boxY1);
        Controls.Add(button1);
        Controls.Add(boxX2);
        Controls.Add(boxX1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox boxX1;
    private TextBox boxX2;
    private Button button1;
    private TextBox boxY1;
    private TextBox boxY2;
    private Button button2;
    private Button button3;
    private TextBox textBox1;
}
