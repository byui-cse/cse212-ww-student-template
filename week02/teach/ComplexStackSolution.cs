/*
 * CSE212 
 * (c) BYU-Idaho
 * 03-Teach - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */

namespace teach_03; 

public static class ComplexStackSolution {
    public static void Main() {
        // True (passes on line 46 ... stack was empty at the end)
        Console.WriteLine(CheckBraces("(a == 3 or (b == 5 and c == 6))"));
        //  False ..wrong opening square bracket (fails on line 38 ... stack had only '(' in it before it was popped and compared with ']')
        //                          here -------\/
        Console.WriteLine(CheckBraces("(students]i].Grade > 80 and students[i].Grade < 90"));
        // False .... missing closing ')' (fails on line 46 ... stack had an extra '(' in it at the end when it was supposed to be empty
        //                 here -------\/
        Console.WriteLine(CheckBraces("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));
    }

    public static bool CheckBraces(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}