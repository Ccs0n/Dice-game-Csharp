// Random dice = new();
//
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
//
// int total;
//
// total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!! +2 bonus to total!");
//         total += 2;
//         
//     }
//     Console.WriteLine($"Your total including the bonus: {total}");
// }
//
//
// if (total >= 16)
// {
//     Console.WriteLine("You win a new car");
// }
//
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }


Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%.}}");
}