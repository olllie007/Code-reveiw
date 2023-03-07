using System;
namespace pack
{
  class Program
  {
    
    
      
        
      
        
    
    static void Main(string[] args)
    {
      int[] cardPack = new int[52];
      string[] suit = {"Hearts", "Diamonds", "Clubs", "Spades"};
      string[] card = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
      string[] deck = new string[52];

      for(int x = 0 ; x<4; x++){
        for(int i=0; i<13; i++){
     
          deck[(i +(x*13))] = card[i] + " of " + suit[x];
        }};

        
          for(int i=0; i<52; i++){
           cardPack[i] = i;
           };
        // shuffel

          int len = cardPack.Length;
          
          for(int i=0; i < len; i++){
            Random randInt = new Random();
            int hold = cardPack[i];
            cardPack [i] = cardPack[(i+randInt.Next(len-i))];
            cardPack[(i+randInt.Next(len-i))] = hold;
            }
            
            int num = 52;
            for(int i=0; i < num; i++){
              Console.WriteLine(deck[cardPack[i]]);
            }
          }
           
           
       
          

        
        
    }
   

    
    
    
  }
  
