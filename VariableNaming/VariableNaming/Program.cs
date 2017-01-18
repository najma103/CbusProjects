using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            int birdsSitting = 4;
            int birdsThatFlewAway = 1;
            int remainingBirds = birdsSitting - birdsThatFlewAway;
            Console.WriteLine("Remaining birds are " + remainingBirds);

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            int birds = 6;
            int nests = 3;
            int birdsMinusNests = birds - nests;
            Console.WriteLine("There are " + birdsMinusNests + " more birds than Nests");

            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */

            int numOfRaccoonsPlaying = 3;
            int numOfRaccoonsWentHome = 2;
            int numOfRaccoonsStillPlaying = numOfRaccoonsPlaying - numOfRaccoonsWentHome;

            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            int numOfFlowers = 5;
            int numOfBees = 3;
            int flowersMinusBees = numOfFlowers - numOfBees;

            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            int onePigeonEating = 1;
            int totalPigeonsEating = onePigeonEating++;

            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int numOfOwlsSitting = 3;
            int totalOwls = numOfOwlsSitting + 2;
            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            int beaversWorking = 2;
            int beaversLeftForSwimming = 1;
            int beaversStillWorking = beaversWorking - beaversLeftForSwimming;
            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            int numOfToucansSitting = 2;
            int totalToucans = numOfToucansSitting + 1;

            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelsMinusNuts = squirrels - nuts;
            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            double quarter = .25;
            double dime = .10;
            double nickel = .05;

            double totalMoney = quarter + dime + (nickel * 2);

            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */

            int brierClassMuffings = 18;
            int macAdamsClassMuffings = 20;
            int flannerClassMuffings = 17;

            int totalBakedMuffins = brierClassMuffings + macAdamsClassMuffings + flannerClassMuffings;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            double yoyoPrice = .24;
            double whistlePrice = .14;
            double totalForToys = yoyoPrice + whistlePrice;
         
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            int largeMarshmallows = 8;
            int minieMarshmallows = 10;
            int totalMarshmallowsUsed = largeMarshmallows + minieMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesOfSnowAtHilt = 29;
            int inchesOfSnowAtBrecknock = 17;
            int hiltSnowLessBrecknockSnow = inchesOfSnowAtHilt - inchesOfSnowAtBrecknock;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int moneyOnHand = 10;
            int moneySpent = 3 + 2;
            int remainingMoney = moneyOnHand - moneySpent;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int initialMarbleCollection = 16;
            int lostMarbles = 7;
            int remainingMarbleCollection = initialMarbleCollection - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int CurrentSeashelCount = 19;
            int neededSeashels = 25;
            int seashelsYetToBeCollected = neededSeashels - CurrentSeashelCount;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int currentBookCount = 38;
            int additionBooks = 10;
            int newBookCount = currentBookCount + additionBooks;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numOfBeeLegs = 6;
            int totalBees = 8;
            int totalBeeLegs = numOfBeeLegs * totalBees;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double icecreamPrice = 0.99;
            int numOfIcecreamsBought = 2;
            double costOfIcecream = icecreamPrice * numOfIcecreamsBought;
            Console.WriteLine("Ice Cream price: 99cents times 2 Ice Creams: " + costOfIcecream);
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksNeeded = 125;
            int rocksOnHand = 64;
            int remainingRocks = rocksNeeded - rocksOnHand;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltMarbles = 38;
            int hiltLostMarbles = 15;
            int hiltRemainingMarbles = hiltMarbles - hiltLostMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int distanceAway = 78;
            int distanceTraveled = 32;
            int remainingDistance = distanceAway - distanceTraveled;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int morningShovelMinutes = 90;
            int afternoonShovelMinutes = 45;
            int totalMinutesShoveling = morningShovelMinutes + afternoonShovelMinutes;

            int numOfHoursShoveling = totalMinutesShoveling / 60;
            double remainingMinutes = (double)totalMinutesShoveling % 60;
            Console.WriteLine("Shovelled on Saturday:  " +  numOfHoursShoveling + " hours and "
                + remainingMinutes + " minutes. ");

            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int hotDogs = 6;
            int cost = 50; // cents
            int totalCost = hotDogs * cost / 100;
            Console.WriteLine("Total Cost of the HotDogs is: " + totalCost + " dollars");

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int HiltMoney = 50; // cents
            int costOfPencil = 7; // cents
            int totalPencilCanBuy = HiltMoney / costOfPencil;
            Console.WriteLine("Mrs. Hilt can buy " + totalPencilCanBuy + " pencils");

            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totButterflies - orangeButterflies;

            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double kateTotalMoney = 1.00;
            double kateCandyCost = 0.54;
            double kateChange = kateTotalMoney - kateCandyCost;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int oldTrees = 13;
            int newTrees = 12;
            int totalTrees = oldTrees + newTrees;
            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int dayInHours = 24;
            int numOfDays = 2;
            int hoursTillJoySeesGrandma = dayInHours * numOfDays;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimCousins = 4;
            int gumsPerCousing = 5;
            int totalGumsKimNeeds = kimCousins * gumsPerCousing;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            double danMoney = 3.00;
            double candyBarCost = 1.00;
            double remainingDanMoney = danMoney - candyBarCost;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numOfBoatsInLake = 5;
            int numOfPeopleInEachBoat = 3;
            int totalNumOfPeople = numOfBoatsInLake * numOfPeopleInEachBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int ellenLegos = 380;
            int ellenNumOfLostLegos = 57;
            int ellensRemainingLegos = ellenLegos - ellenNumOfLostLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurBakedMuffins = 35;
            int totalMuffinsArthurNeeds = 83;
            int muffinsYetBaked = totalMuffinsArthurNeeds - arthurBakedMuffins;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int willyCrayonsLessLucyCrayons = willyCrayons - lucyCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numOfStickersPerPage = 10;
            int numOfPages = 22;
            int totalStickers = numOfStickersPerPage * numOfPages;
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalCupCakes = 96;
            int totalChildren = 8;
            int cupCakesPerChild = totalCupCakes / totalChildren;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int totalGingerbread = 47;
            int gingerbreadPerJar = 6;
            int gingerbreadNotInJar = totalGingerbread % gingerbreadPerJar;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int totPrepedCroisants = 59;
            int totNeighbors = 8;
            int remainingCroisantsForMarian = totPrepedCroisants % totNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            int oatmealCookies = 276;
            int numOfCookiesPerTray = 12;
            int numOfTraysNeeded = oatmealCookies / numOfCookiesPerTray;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzels = 480;
            int servingSize = 12;
            int totalServings = totalPretzels / servingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int lemonCupCakes = 53;
            int lemonCupCakesLeftAtHome = 2;
            int lemonCupCakesPerBox = 3;
            int numOfLemonCupCakesBoxes =
                (lemonCupCakes - lemonCupCakesLeftAtHome) / lemonCupCakesPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int totalCarrots = 74;
            int totalGuests = 12;
            int uneatenCarrots = totalCarrots % totalGuests;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numOfTedyBears = 98;
            int totalTedyPerShelf = 7;
            int totalShelvesNeeded = numOfTedyBears / totalTedyPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalFamilyPictures = 480;
            int maxSizePerAlbum = 20;
            int totalAlbumsNeeded = totalFamilyPictures / maxSizePerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int numOfCardsPerBox = 8;
            int totFilledBoxes = totalTradingCards / numOfCardsPerBox;
            int totRemainingCards = totalTradingCards % numOfCardsPerBox;
            Console.WriteLine("Full boxes : " + totFilledBoxes + " remaining cards: "
                + totRemainingCards);

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int numOfSusieBooks = 210;
            int numOfShelfs = 10;
            int totalBooksPerShelf = numOfSusieBooks / numOfShelfs;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int numOfCristinaCroissants = 17;
            int numOfGuests = 7;
            double equalPortion = (double)numOfCristinaCroissants / numOfGuests;


        }
    }
}
