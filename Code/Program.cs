using System;
public class Program {
    static void Main(string[]args){
        Console.Write("Space amount : ");
        int amount = int.Parse(Console.ReadLine());
        Char[] Space = new Char[amount];
        bool end = false;
        

        if (amount <= 0){
            Console.WriteLine("Error : insert amount that higher than 0");
            end = true;
        }else{

            for(int a = 0; a < amount; a++){
                Space[a] = '_';
                /*Console.Write("{0} ",Space[a]); //check space*/
            }

            do{
                Console.WriteLine("Book the space : ");
                int book1 = int.Parse(Console.ReadLine());
                int book2 = int.Parse(Console.ReadLine());
                int count = 0;

                for(int c = 0; c < amount; c++){
                    if (Space[c] == 'X'){
                        count = count + 1;
                    }
                }
                
                if (count == (amount - 1)){
                    Console.WriteLine("The entrance can't be reserved."); 
                    end = true;
                }else if (book1 <= 0 && book2 <= 0){
                    end = true;
                }else if (book1 > amount || book2 > amount){
                    Console.WriteLine("Error : insert number that not higher than {0}",amount);
                    end = true;
                }else if (Space[book1 - 1] == 'X' || Space[book2 - 1] == 'X'){
                    Console.WriteLine("The stall is reserved."); 
                }else{                
                    if (book1 > 0 && book2 <=0){
                        Space[book1 - 1] = 'X';
                    }else if (book2 > 0 && book1 <=0){
                        Space[book2 - 1] = 'X';
                    }else{
                        Space[book1 - 1] = 'X';
                        Space[book2 - 1] = 'X';
                    }
                }
                
                Console.WriteLine("-------------------------"); 
                for(int b = 0; b < amount; b++){
                    Console.Write("{0} ",Space[b]); 
                }
                Console.WriteLine(" "); 
            }while(!end);
        }
    }
}    