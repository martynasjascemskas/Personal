
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

public class main {
    public static void main(String [] args) throws IOException
    {
        List<String> wordList = getWords();
        int letterNumbers[] = new int[26];
        String letterList[] = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        calculateLetters(wordList, letterList, letterNumbers);
        List<Double> intList = new ArrayList<Double>(letterNumbers.length);
        for(int i = 0; i < wordList.size(); i++)
        {
            intList.add(calculate_word_common(wordList.get(i), letterNumbers, letterList));
        }
        sort_by_common(wordList, intList, letterList);
        /*for(int i = 0; i < wordList.size(); i++)
        {
            System.out.print(wordList.get(i) + " ");
            System.out.println(calculate_word_common(wordList.get(i), letterNumbers, letterList));
        }*/
        Scanner input = new Scanner(System.in);
        while(true)
        {
            System.out.print("Please enter the input: " + wordList.get(0) + "\nEnter: ");
            String word1 = input.nextLine().toLowerCase();

            System.out.print("Enter a 5 character feedback: 0=Grey, 1=Yellow, 2=Green: ");
            String feedback = input.nextLine().toLowerCase();

            getSuggestions(word1, feedback, wordList, intList);
            System.out.println("Computer Suggestions: ");
            if(wordList.size() < 1)
            {
                System.out.println("No Suggestions");
                return;
            }
            else if(wordList.size() < 10)
            {
                for(int j = 0; j < wordList.size(); j++)
                {
                    System.out.println(wordList.get(j) + " " + intList.get(j));
                    //System.out.print(intList.get(j));
                } 
            }
            else{
                for(int j = 0; j < 10; j++)
                {
                    System.out.println(wordList.get(j) + " " + intList.get(j));
                }
            }
        }
    }
    public static void getSuggestions(String input, String feedback, List<String> wordList, List<Double> intList){
        String[] words = new String[wordList.size()];
        wordList.toArray(words);
        for(int pos = 0; pos < input.length(); pos++){
            char current = input.charAt(pos);
            char feedbackChar = feedback.charAt(pos); //0(grey), 1(yellow), 2(green)
            if(isGray(feedbackChar)){
                for(int i = 0; i < wordList.size(); i++){
                    if(containsChar(wordList.get(i), current))
                    {
                        wordList.remove(i);
                        intList.remove(i);
                        i--;
                    }
                }
            }
            else if(isYellow(feedbackChar)){
                for(int i = 0; i < wordList.size(); i++)
                {
                    if(!containsChar(wordList.get(i), current)) //doesn"t contain remove.
                    {                 
                        wordList.remove(i);
                        intList.remove(i);
                        i--;
                    }
                    else if(wordList.get(i).charAt(pos) == (current))//same position remove
                    {
                        wordList.remove(i);
                        intList.remove(i);
                        i--;
                    }
                }
            }
            else if(isGreen(feedbackChar)){
                for(int i = 0; i < wordList.size(); i++)
                {
                    if(wordList.get(i).charAt(pos) != (current) && containsChar(wordList.get(i), current))
                    {
                        wordList.remove(i);
                        intList.remove(i);
                        i--;
                    }
                }
            }
            else{
                System.out.println("Something poopy at:" +feedbackChar + " and " + current);
            }
        }
    }
    public static void calculateLetters(List<String> wordList, String[] letterList, int letterNumbers[])
    {
        double total = 0.0;
        for(int i = 0; i < letterList.length; i++)
        {
            int score = 0;
            for(int j = 0; j < wordList.size(); j++)
            {
                if(wordList.get(j).contains(letterList[i]))
                {
                    score++;
                    letterNumbers[i] = score;
                }
            }
            total = total + letterNumbers[i];
        }
        /*for(int i = 0; i < letterNumbers.length; i++)
        {
            double sum = letterNumbers[i]/total;
            //System.out.println(letterList[i] + ": " + sum);
        }
        //System.out.println(total);*/
    }
    public static double getValue(String letter, int letterNumbers[], String[] letterList) //gets value of a singular letter
    {
        double total = 0.0;
        for(int i = 0; i < letterList.length; i++)
        {
            total = total + letterNumbers[i];
        }
        for(int i = 0; i < letterList.length; i++)
        {
            double sum = (letterNumbers[i]/total);
            if(letter.equals(letterList[i]))
            {
                return sum;
            }
        }
        return -1.0;
    }
    public static double calculate_word_common(String word, int letterNumbers[], String[] letterList){
        double score = 0.0;
        for(int i = 0; i < word.length(); i++)
        {
            char current = word.charAt(i);
            String current1 = Character.toString(current);
            score = score + getValue(current1, letterNumbers, letterList);
        }
        return score / (word.length() - getUnique(word).length() + 1);
    }
    public static void sort_by_common(List<String> wordList, List<Double> intList, String[] letterList)
    {
        boolean sorted = false;
        double temp;
        String temp1;
        while(!sorted){
            sorted = true;
            for(int i = 0; i < intList.size()-1; i++)
            {
                if(intList.get(i) < intList.get(i+1))
                {
                    temp = intList.get(i);
                    intList.set(i, intList.get(i+1));
                    intList.set(i+1, temp);
                    
                    temp1 = wordList.get(i);
                    wordList.set(i, wordList.get(i+1));
                    wordList.set(i+1, temp1);

                    sorted = false;
                }
            }
        }
        /*for(int i = 0; i < 10; i++)
        {
            System.out.println(intList.get(i));
            System.out.print(wordList.get(i) + " ");
        }*/
    }
    public static String getUnique(String word)
    {
        String something = "";
        for(int i = 0; i < word.length(); i++)
        {
            int flag = 0;
            for(int j = 0; j < word.length(); j++)
            {
                if(word.charAt(i) == word.charAt(j) && i != j)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                something = something + word.charAt(i);
            }
        }
        return something;
    }
    public static boolean isGray(char x)
    {
        if(x == '0')
        {
            return true;
        }
        return false;
    }
    public static boolean isYellow(char x)
    {
        if(x == '1')
        {
            return true;
        }
        return false;
    }
    public static boolean isGreen(char x)
    {
        if(x == '2')
        {
            return true;
        }
        return false;
    }
    public static boolean containsChar(String str, char x)
    {
        for(int i = 0; i < str.length(); i++)
        {
            if(str.charAt(i) == x)
            {
                return true;
            }
        }
        return false;
    }
    private static List<String> getWords() throws IOException {

        List<String> wordList = new ArrayList<String>();

        File file = new File("words.txt");
        BufferedReader br = new BufferedReader(new FileReader(file));

        String word;
        while ((word = br.readLine()) != null) {
            wordList.add(word.toLowerCase());
        }
        return wordList;
    }
}