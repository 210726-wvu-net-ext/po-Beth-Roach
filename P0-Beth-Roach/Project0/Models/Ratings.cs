using System;


namespace Models
{
    public class Rating
     {
        public static double Ratings(double newRating, double totalRatings, double numberOfRatings)
         {
            
            Console.ReadLine(newRating);
            double rating = 0;
            totalRatings = newRating + rating;
            numberOfRatings = count.newRating;
            if(newRating>0 && totalRatings>0 && numberOfRatings>0)
            {
               
                var aveRating=((totalRatings + newRating)/numberOfRatings);
            
            }
            else
                throw new ArgumentException("Rating must be a valid number");
         }
    }
}