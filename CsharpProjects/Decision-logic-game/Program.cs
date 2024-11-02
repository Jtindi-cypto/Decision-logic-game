Random dice = new Random();

int roll1 = dice.Next(1 , 7);
int roll2 = dice.Next(1 , 7);
int roll3 = dice.Next(1 , 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if(total > 14){

    Console.WriteLine("Congratulations You Win!");
} else { 
    Console.WriteLine("Sorry try again you lose");
}

//create double chances rules in the game
if ((roll1 == roll2) ||(roll2 == roll3) || (roll1 == roll3)){

    Console.WriteLine("You rolled doubles +2 bonus to the total score");
    total+=2;
}

//add triple bonuses code
if ((roll1 == roll2) && (roll2==roll3)){
    Console.WriteLine("You have have rolled Triples! + 6 Bonus points");
    total +=6;
}
