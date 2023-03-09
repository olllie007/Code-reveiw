/*
Card shuffler and outputter by Oliver Weightman
This code creates 2 decks one with a list of cards
and a second deck with the numbers 0 to 51 
which are used to index the first list when outputting
a card to the user
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CMP1903M_A01_2223{
    class Pack
    {
        
        
        static Pack(){
            //List<Card> pack;
        //Creating the index array to index a card
        int[] cardPack = new int[52];
        // creating the deck to be outputted
        string[] suit = {"Hearts", "Diamonds", "Clubs", "Spades"};
        string[] card = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};
        string[] deck = new string[52];
            // create the index deck and the output deck
            for(int x = 0 ; x<4; x++){
                for(int i=0; i<13; i++){
            
                deck[(i +(x*13))] = card[i] + " of " + suit[x];
            }};

                
            for(int i=0; i<52; i++){
                cardPack[i] = i;//.ToString();
            };
        }

        public void shuffleCardPack(ref int[] cardPack){
            // shuffels the deck code was taken for a youtube toutorial https://www.youtube.com/watch?v=u03XdDYIOkc&t=10s
            int len = cardPack.Length;
          //asigns a random integer to the list
            for(int i=0; i < len; i++){
                Random randInt = new Random();
                int hold = cardPack[i];
                cardPack [i] = cardPack[(i+randInt.Next(len-i))];
                cardPack[(i+randInt.Next(len-i))] = hold;
                
            }  
           
        }
                
        
        void deal(string deck, int[] cardPack){
            // outputs the top card
            Console.WriteLine(deck[cardPack[0]]);
            //return deck[cardPack[0]];
            
        }
         void dealCard(int amount, int[] cardPack, string deck){
            // outputs the desired amount of cards and checks that it can only output upto 52 cards
            if (amount < 53 ); {
                for(int i=0; i < amount; i++){
                    Console.WriteLine(deck[cardPack[i]]);
                
                  
            };};
             //return deck[cardPack[i]];
            
    }
        
        
    }}
public class Program
{
    static void Main() {}
}