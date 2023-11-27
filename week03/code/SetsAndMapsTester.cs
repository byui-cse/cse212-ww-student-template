using System.Text.Json;

public static class SetsAndMapsTester {
    public static void Run() {
        // Problem 1: Find Pairs with Sets
        Console.WriteLine("\n=========== Finding Pairs TESTS ===========");
        DisplayPairs(new[] { "am", "at", "ma", "if", "fi" });
        // ma & am
        // fi & if
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "bc", "cd", "de", "ba" });
        // ba & ab
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "ba", "ac", "ad", "da", "ca" });
        // ba & ab
        // da & ad
        // ca & ac
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "ac" }); // No pairs displayed
        Console.WriteLine("---------");
        DisplayPairs(new[] { "ab", "aa", "ba" });
        // ba & ab
        Console.WriteLine("---------");
        DisplayPairs(new[] { "23", "84", "49", "13", "32", "46", "91", "99", "94", "31", "57", "14" });
        // 32 & 23
        // 94 & 49
        // 31 & 13

        // Problem 2: Degree Summary
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== Census TESTS ===========");
        Console.WriteLine(string.Join(", ", SummarizeDegrees("census.txt")));
        // Results may be in a different order:
        // <Dictionary>{[Bachelors, 5355], [HS-grad, 10501], [11th, 1175],
        // [Masters, 1723], [9th, 514], [Some-college, 7291], [Assoc-acdm, 1067],
        // [Assoc-voc, 1382], [7th-8th, 646], [Doctorate, 413], [Prof-school, 576],
        // [5th-6th, 333], [10th, 933], [1st-4th, 168], [Preschool, 51], [12th, 433]}

        // Problem 3: Anagrams
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== Anagram TESTS ===========");
        Console.WriteLine(IsAnagram("CAT", "ACT")); // true
        Console.WriteLine(IsAnagram("DOG", "GOOD")); // false
        Console.WriteLine(IsAnagram("AABBCCDD", "ABCD")); // false
        Console.WriteLine(IsAnagram("ABCCD", "ABBCD")); // false
        Console.WriteLine(IsAnagram("BC", "AD")); // false
        Console.WriteLine(IsAnagram("Ab", "Ba")); // true
        Console.WriteLine(IsAnagram("A Decimal Point", "Im a Dot in Place")); // true
        Console.WriteLine(IsAnagram("tom marvolo riddle", "i am lord voldemort")); // true
        Console.WriteLine(IsAnagram("Eleven plus Two", "Twelve Plus One")); // true
        Console.WriteLine(IsAnagram("Eleven plus One", "Twelve Plus One")); // false

        // Problem 4: Maze
        Console.WriteLine("\n=========== Maze TESTS ===========");
        Dictionary<ValueTuple<int, int>, bool[]> map = SetupMazeMap();
        var maze = new Maze(map);
        maze.ShowStatus(); // Should be at (1,1)
        maze.MoveUp(); // Error
        maze.MoveLeft(); // Error
        maze.MoveRight();
        maze.MoveRight(); // Error
        maze.MoveDown();
        maze.MoveDown();
        maze.MoveDown();
        maze.MoveRight();
        maze.MoveRight();
        maze.MoveUp();
        maze.MoveRight();
        maze.MoveDown();
        maze.MoveLeft();
        maze.MoveDown(); // Error
        maze.MoveRight();
        maze.MoveDown();
        maze.MoveDown();
        maze.MoveRight();
        maze.ShowStatus(); // Should be at (6,6)

        // Problem 5: Earthquake
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== Earthquake TESTS ===========");
        EarthquakeDailySummary();

        // Sample output from the function.  Number of earthquakes, places, and magnitudes will vary.
        // 1km NE of Pahala, Hawaii - Mag 2.36
        // 58km NW of Kandrian, Papua New Guinea - Mag 4.5
        // 16km NNW of Truckee, California - Mag 0.7
        // 9km S of Idyllwild, CA - Mag 0.25
        // 14km SW of Searles Valley, CA - Mag 0.36
        // 4km SW of Volcano, Hawaii - Mag 1.99
    }

    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for displaying all symmetric pairs of words.  
    ///
    /// For example, if <c>words</c> was: <c>[am, at, ma, if, fi]</c>, we would display:
    /// <code>
    /// am &amp; ma
    /// if &amp; fi
    /// </code>
    /// The order of the display above does not matter. <c>at</c> would not 
    /// be displayed because <c>ta</c> is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    private static void DisplayPairs(string[] words) {
        // To display the pair correctly use something like:
        // Console.WriteLine($"{word} & {pair}");
        // Each pair of words should displayed on its own line.
    }

    /// <summary>
    /// Read a census file and summarize the degrees (education)
    /// earned by those contained in the file.  The summary
    /// should be stored in a dictionary where the key is the
    /// degree earned and the value is the number of people that 
    /// have earned that degree.  The degree information is in
    /// the 4th column of the file.  There is no header row in the
    /// file.
    /// </summary>
    /// <param name="filename">The name of the file to read</param>
    /// <returns>fixed array of divisors</returns>
    /// #############
    /// # Problem 2 #
    /// #############
    private static Dictionary<string, int> SummarizeDegrees(string filename) {
        var degrees = new Dictionary<string, int>();
        foreach (var line in File.ReadLines(filename)) {
            var fields = line.Split(",");
            // Todo Problem 2 - ADD YOUR CODE HERE
        }

        return degrees;
    }

    /// <summary>
    /// Determine if 'word1' and 'word2' are anagrams.  An anagram
    /// is when the same letters in a word are re-organized into a 
    /// new word.  A dictionary is used to solve the problem.
    /// 
    /// Examples:
    /// is_anagram("CAT","ACT") would return true
    /// is_anagram("DOG","GOOD") would return false because GOOD has 2 O's
    /// 
    /// Important Note: When determining if two words are anagrams, you
    /// should ignore any spaces.  You should also ignore cases.  For 
    /// example, 'Ab' and 'Ba' should be considered anagrams
    /// 
    /// Reminder: You can access a letter by index in a string by 
    /// using the [] notation.
    /// </summary>
    /// #############
    /// # Problem 3 #
    /// #############
    private static bool IsAnagram(string word1, string word2) {
        // Todo Problem 3 - ADD YOUR CODE HERE
        return false;
    }

    /// <summary>
    /// Sets up the maze dictionary for problem 4
    /// </summary>
    private static Dictionary<ValueTuple<int, int>, bool[]> SetupMazeMap() {
        Dictionary<ValueTuple<int, int>, bool[]> map = new() {
            { (1, 1), new[] { false, true, false, true } },
            { (1, 2), new[] { false, true, true, false } },
            { (1, 3), new[] { false, false, false, false } },
            { (1, 4), new[] { false, true, false, true } },
            { (1, 5), new[] { false, false, true, true } },
            { (1, 6), new[] { false, false, true, false } },
            { (2, 1), new[] { true, false, false, true } },
            { (2, 2), new[] { true, false, true, true } },
            { (2, 3), new[] { false, false, true, true } },
            { (2, 4), new[] { true, true, true, false } },
            { (2, 5), new[] { false, false, false, false } },
            { (2, 6), new[] { false, false, false, false } },
            { (3, 1), new[] { false, false, false, false } },
            { (3, 2), new[] { false, false, false, false } },
            { (3, 3), new[] { false, false, false, false } },
            { (3, 4), new[] { true, true, false, true } },
            { (3, 5), new[] { false, false, true, true } },
            { (3, 6), new[] { false, false, true, false } },
            { (4, 1), new[] { false, true, false, false } },
            { (4, 2), new[] { false, false, false, false } },
            { (4, 3), new[] { false, true, false, true } },
            { (4, 4), new[] { true, true, true, false } },
            { (4, 5), new[] { false, false, false, false } },
            { (4, 6), new[] { false, false, false, false } },
            { (5, 1), new[] { true, true, false, true } },
            { (5, 2), new[] { false, false, true, true } },
            { (5, 3), new[] { true, true, true, true } },
            { (5, 4), new[] { true, false, true, true } },
            { (5, 5), new[] { false, false, true, true } },
            { (5, 6), new[] { false, true, true, false } },
            { (6, 1), new[] { true, false, false, false } },
            { (6, 2), new[] { false, false, false, false } },
            { (6, 3), new[] { true, false, false, false } },
            { (6, 4), new[] { false, false, false, false } },
            { (6, 5), new[] { false, false, false, false } },
            { (6, 6), new[] { true, false, false, false } }
        };
        return map;
    }

    /// <summary>
    /// This function will read JSON (Javascript Object Notation) data from the 
    /// United States Geological Service (USGS) consisting of earthquake data.
    /// The data will include all earthquakes in the current day.
    /// 
    /// JSON data is organized into a dictionary. After reading the data using
    /// the built-in HTTP client library, this function will print out a list of all
    /// earthquake locations ('place' attribute) and magnitudes ('mag' attribute).
    /// Additional information about the format of the JSON data can be found 
    /// at this website:  
    /// 
    /// https://earthquake.usgs.gov/earthquakes/feed/v1.0/geojson.php
    /// 
    /// </summary>
    private static void EarthquakeDailySummary() {
        const string uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using var client = new HttpClient();
        using var getRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
        using var jsonStream = client.Send(getRequestMessage).Content.ReadAsStream();
        using var reader = new StreamReader(jsonStream);
        var json = reader.ReadToEnd();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json, options);

        // TODO:
        // 1. Add code in FeatureCollection.cs to describe the JSON using classes and properties 
        // on those classes so that the call to Deserialize above works properly.
        // 2. Add code below to print out each place a earthquake has happened today and its magitude.
    }
}