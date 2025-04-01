using System.Text.RegularExpressions;

namespace project2.hm.HM_12
{
    internal class RegularPhrases
    {
        public static bool isRestNameValid(string name)
        {
            string pattern = @"^[^%&)(]+$";
            return Regex.IsMatch(name, pattern);
        }
        public static bool isRestAddressValid(string address)
        {
            string pattern = @"^[A-Za-z0-9\s]+$";
            return Regex.IsMatch(address, pattern);
        }
        public static bool isRestCuisineValid(string cuisine)
        {
            string pattern = @"^[A-Za-z]+$";
            return Regex.IsMatch(cuisine, pattern);
        }
        public static bool isRatingValid(string rating)
        {
            string pattern = @"^(1[0-2]|[1-9])$";
            return Regex.IsMatch(rating, pattern);
        }
    }
    internal class RestarauntAccount
    {
        public string Nickname { get; }
        public string Email { get; }
        public string Phone { get; }
        public string Name { get; }
        public string Address { get; }
        public string Cuisine { get; }
        public string RestaurantPhone { get; }
        public int Rating { get; }
        public string Review { get; }

        public RestarauntAccount(string nickname, string email, string phone, string name, string address, string cuisine, string restaurantPhone, string rating, string review)
        {
            if (!Regex.IsMatch(email, @"^[\w.-]+@[a-zA-Z_-]+?\.[a-zA-Z]{2,3}$"))
                throw new ArgumentException("Invalid mail");
            if (!Regex.IsMatch(phone, @"^\+?\d{10,15}$"))
                throw new ArgumentException("Invalid phone number.");
            if (!Regex.IsMatch(name, @"^[^%&)(]+$"))
                throw new ArgumentException("Invalid restaraunt name.");
            if (!Regex.IsMatch(address, @"^[A-Za-z0-9\s]+$"))
                throw new ArgumentException("Invalid address.");
            if (!Regex.IsMatch(cuisine, @"^[A-Za-z]+$"))
                throw new ArgumentException("Invalid cuisine.");
            if (!Regex.IsMatch(restaurantPhone, @"^\+?\d{10,15}$"))
                throw new ArgumentException("Invalid contact number.");
            if (!Regex.IsMatch(rating, @"^(1[0-2]|[1-9])$"))
                throw new ArgumentException("Invalid rating.");

            Nickname = nickname;
            Email = email;
            Phone = phone;
            Name = name;
            Address = address;
            Cuisine = cuisine;
            RestaurantPhone = restaurantPhone;
            Rating = int.Parse(rating);
            Review = review;

            using (StreamWriter sw = new StreamWriter($"{Nickname}.txt"))
            {
                sw.WriteLine(ToString());
            }
        }

        public override string ToString()
        {
            return $"Nickname: {Nickname}\nEmail: {Email}\nPhone: {Phone}\n" +
                $"Restaraunt name: {Name}\nAddress: {Address}\nCuisine: {Cuisine}\n" +
                $"Contact phone: {RestaurantPhone}\nRating: {Rating}\nReview: {Review}\n";
        }
    }
}
