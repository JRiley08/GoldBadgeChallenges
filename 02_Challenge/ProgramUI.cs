using System;
using System.Collections.Generic;

namespace _02_Challenge
{
    internal class ProgramUI
    {
        ClaimDataRepo _claimDataRepo = new ClaimDataRepo();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose a menu item\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter new claim\n" +
                    "4. Exit");

                string input = Console.ReadLine();
                int choice = int.Parse(input);
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        ViewEntireList();
                        break;
                    case 2:
                        TakeCareOfNextClaim();
                        break;
                    case 3:
                        EnterANewClaim();
                        break;
                    case 4:
                        running = false;
                        break;
                }




            }


        }

        private void SeedList()
        {
            ClaimData claimOne = new ClaimData(1, ClaimType.Car, "Car Accident", 400.00m, new DateTime(2018, 04, 28), new DateTime(2018, 04, 29));
            ClaimData claimTwo = new ClaimData(2, ClaimType.House, "Flooded Basement", 500.00m, new DateTime(2018, 05, 20), new DateTime(2018, 07, 20));
            ClaimData claimThree = new ClaimData(3, ClaimType.Theft, "Stolen Wallet", 40.00m, new DateTime(2018, 05, 20), new DateTime(2018, 05, 25));

            _claimDataRepo.AddClaimToQueue(claimOne);
            _claimDataRepo.AddClaimToQueue(claimTwo);
            _claimDataRepo.AddClaimToQueue(claimThree);


        }
        private void ViewEntireList()
        {
            {
                Queue<ClaimData> _claimlist = _claimDataRepo.GetClaimInfo();

                foreach (ClaimData claim in _claimlist)
                {
                    Console.WriteLine($"{claim.ClaimID} {claim.ClaimType} {claim.Description} {claim.Amount} {claim.DateAC} {claim.DateC} {claim.IsValid}");
                }
                Console.ReadKey();
                Console.Clear();


            }
        }
          private void TakeCareOfNextClaim()
            {
                {
                    ClaimData claim = _claimDataRepo.NextClaim();
                    Console.WriteLine($"{claim.ClaimID} {claim.ClaimType} {claim.Description} {claim.Amount} {claim.DateAC} {claim.DateC} {claim.IsValid}");

                    Console.WriteLine("Would you like to work on this claim?\n" +
                        "1. Yes" +
                        "2. No");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        _claimDataRepo.RemoveClaimFromQueue();
                    }
                }

            }
        



        private void EnterANewClaim()
        {
            Console.WriteLine("Enter the claim id");
            int claimID = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Enter in the type of claim you are listing\n" +
                "1.Car\n" +
                "2.House\n" +
                "3.Theft\n");
            int claimType = ParseInput();
            Console.Clear();

            ClaimType type = ClaimType.House;
            switch (claimID)
            {
                case 1:
                    type = ClaimType.Car;
                    break;
                case 2:
                    type = ClaimType.House;
                    break;
                case 3:
                    type = ClaimType.Theft;
                    break;

            }
            Console.Clear();

            Console.WriteLine("Enter in the description of the claim");
            string description = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the amount of the claim");
            int amount = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Enter the date the accident occured");
            DateTime dateAC;
            if (DateTime.TryParse(Console.ReadLine(), out dateAC))
            {
                Console.WriteLine("The date entered is:" + dateAC);
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the date the claim was filed");
            DateTime dateC;
            if (DateTime.TryParse(Console.ReadLine(), out dateC))
            {
                Console.WriteLine("The date entered is:" + dateC);
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }
            Console.ReadLine();
            Console.Clear();
            ClaimData claimData = new ClaimData(claimID, type, description, amount, dateAC, dateC);
            _claimDataRepo.AddClaimToQueue(claimData);

        }
        private int ParseInput()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 4)
            {
                Console.WriteLine("Your input was invalid please enter valid menu number");
                input = ParseInput();
            }
            return input;
        }

    }
}