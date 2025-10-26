using Microsoft.VisualBasic;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void LblHeading_Click(object sender, EventArgs e)
    {
    }

    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void label6_Click(object sender, EventArgs e)
    {
    }
    
    private void BtnUserChoosesRock_Click(object sender, EventArgs e)
    {
        string first = "rock", second = "paper", third = "scissors", computerChoice;
        string [] words = {first, second, third};
        int draw=0, win=0, lose=0;
        
        Random rnd = new Random();
        
        computerChoice = words[rnd.Next(0, words.Length)];
        label5.Text = computerChoice;

        switch (computerChoice)
        {
            case "rock":
                label6.Text = "Draw!";
                draw++;
                break;
            case "paper":
                label6.Text = "You lose!";
                lose++;
                break;
            case "scissors":
                label6.Text = "You win!";
                win++;
                break;
        }
    }

    private void BtnUserChoosesPaper_Click(object sender, EventArgs e)
    {
        string first = "rock", second = "paper", third = "scissors", computerChoice;
        string [] words = {first, second, third};
        int draw=0, win=0, lose=0;
        
        Random rnd = new Random();
        
        computerChoice = words[rnd.Next(0, words.Length)];
        label5.Text = computerChoice;

        switch (computerChoice)
        {
            case "rock":
                label6.Text = "You win!";
                win++;
                break;
            case "paper":
                label6.Text = "Draw!";
                draw++;
                break;
            case "scissors":
                label6.Text = "You lose!";
                lose++;
                break;
        }
    }
    
    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string first = "rock", second = "paper", third = "scissors", computerChoice;
        string [] words = {first, second, third};
        int draw=0, win=0, lose=0;
        
        Random rnd = new Random();
        
        computerChoice = words[rnd.Next(0, words.Length)];
        label5.Text = computerChoice;

        switch (computerChoice)
        {
            case "rock":
                label6.Text = "You lose!";
                lose++;
                break;
            case "paper":
                label6.Text = "You win!";
                win++;
                break;
            case "scissors":
                label6.Text = "Draw!";
                draw++;
                break;
        }
    }
}