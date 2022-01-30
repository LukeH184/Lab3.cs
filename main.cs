using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Question q1 = new Question();
    Quiz quiz = new Quiz();
    int choice;
    while(true){
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a question to the quiz");
    Console.WriteLine("2. Remove a question from the quiz");
    Console.WriteLine("3. Modify a question in the quiz");
    Console.WriteLine("4. Take the quiz");
    Console.WriteLine("5. Quit");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch(choice){
      case 1:
      quiz.add_question();
        break;
      case 2:
      quiz.remove_question();
        break;
      case 3: 
      quiz.modify_Question();
        break;
      case 4:
      quiz.take_quiz();
        break;
      case 5:
      System.Environment.Exit(0);
        break;
      default:
        break;
    }
  }
}
  public class Question{
    private string text;
    private string answer;
    private int difficulty;
    public Question(){}
    public Question(string txt, string ans, int dif){
      this.text = txt;
      this.answer = ans;
      this.difficulty = dif;
    }
    public string getText(){
      return text;
    }
    public string getAnswer(){
      return answer;
    }
    public int getDif(){
      return difficulty;
    }
    public void setText(string txt){
      text = txt;
    }
    public void setAnswer(string ans){
      answer = ans;
    }
    public void setDif(int dif){
      difficulty = dif;
    }
  }
  public class Quiz{
    ArrayList questions = new ArrayList();
    public void add_question(){
      Console.WriteLine("What is the Question Text?");
      string quesTxt = Console.ReadLine();
      Console.WriteLine("What is the Question Answer?");
      string quesAns =Console.ReadLine();
      Console.WriteLine("What is the Question difficulty?");
      int quesDif = Convert.ToInt32(Console.ReadLine());
      questions.Add(new Question(quesTxt, quesAns, quesDif));
    }
    public void remove_question(){
      int remove_index;
      Console.WriteLine("Which Question would you like to remove?");
      for (int i = 0; i < questions.Count; i++){
        Question index = (Question) questions[i];
        Console.WriteLine((i + 1) + ". " + (index.getText()));
      }
      remove_index = Convert.ToInt32(Console.ReadLine()) - 1;
      questions.RemoveAt(remove_index);
    }
    public void modify_Question(){
      int modify_index;
      Console.WriteLine("Which Question would you like to modify?");
      for (int i = 0; i < questions.Count; i++){
        Question index = (Question) questions[i];
        Console.WriteLine((i + 1) + ". " + (index.getText()));
      }
      modify_index = Convert.ToInt32(Console.ReadLine()) - 1;
      Console.WriteLine("What is the new Question Text?");
      string quesTxt = Console.ReadLine();
      Console.WriteLine("What is the new Question Answer?");
      string quesAns =Console.ReadLine();
      Console.WriteLine("What is the new Question difficulty?");
      int quesDif = Convert.ToInt32(Console.ReadLine());
      questions[modify_index] = (new Question(quesTxt, quesAns, quesDif));
    }
    public void take_quiz(){
      int score = 0;
      foreach (Question i in questions){
        Console.WriteLine(i.getText());
        Console.Write("ANSWER: ");
        if(Console.ReadLine() == i.getAnswer()){
          score++;
          Console.WriteLine("CORRECT");
        }
        else {
          Console.WriteLine("INCORRECT");
        }
        Console.WriteLine("");
        Console.WriteLine("Your score was " + score);
      }
    }
  }
}
