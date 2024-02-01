using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private TextBox side1TextBox;
    private TextBox side2TextBox;
    private Button calculateButton;
    private TextBox resultTextBox;

    public MainForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        // Создание и настройка компонентов формы

        side1TextBox = new TextBox();
        side1TextBox.Location = new Point(10, 10);
        side1TextBox.Size = new Size(100, 20);

        side2TextBox = new TextBox();
        side2TextBox.Location = new Point(10, 40);
        side2TextBox.Size = new Size(100, 20);

        calculateButton = new Button();
        calculateButton.Location = new Point(10, 70);
        calculateButton.Size = new Size(100, 30);
        calculateButton.Text = "Calculate";
        calculateButton.Click += CalculateButton_Click;

        resultTextBox = new TextBox();
        resultTextBox.Location = new Point(10, 110);
        resultTextBox.Size = new Size(200, 100);
        resultTextBox.Multiline = true;
        resultTextBox.ReadOnly = true;

        Controls.Add(side1TextBox);
        Controls.Add(side2TextBox);
        Controls.Add(calculateButton);
        Controls.Add(resultTextBox);
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        double side1 = double.Parse(side1TextBox.Text);
        double side2 = double.Parse(side2TextBox.Text);

        Triangle triangle = new Triangle(side1, side2);
        resultTextBox.Text = triangle.GetInfo();
    }

    public static void Main()
    {
        Application.Run(new MainForm());
    }
}