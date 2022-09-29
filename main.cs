using System;

class Program {
  public static void Main (string[] args) {
    string[,] goodies =  {{"Jules gets jewelry","and a lolipop"},{"Bob gets chocolate","and jewelry"} ,{"jane gets Puzzle","and a fruit candy"},{"jane gets Puzzle","and a fruit candy"},{"Samir gets a lolipop","and a puzzle"}};

    for(int r=0; r<5; r++)
    {
      for(int c=0; c<2; c++)
      {
      Console.WriteLine(goodies[r,c]);
      }
    } 
}
}