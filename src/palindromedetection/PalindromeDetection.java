/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package palindromedetection;

import java.util.LinkedList;
import java.util.Scanner;

/**
 *
 * @author CPP_Curriculum
 */
public class PalindromeDetection {

    private static Scanner in = new Scanner(System.in);
    private static String input;
    private static LinkedList<String> palindromeList = new LinkedList();
    private static String[] splitInput;
    private static int palindromeLength;
    
    public static void main(String[] args) {
        
        obtainingPalindrome();
        
        if (palindromeList.size()<=1){
            System.out.println("Not enough letters to make a decision");
        }
        else{       
            while (palindromeList.size()>=0){
                if (palindromeList.size()>1){
                    if (palindromeList.getFirst().equals(palindromeList.getLast())){
                        palindromeList.removeFirst();
                        palindromeList.removeLast();
                    }
                    else{
                        System.out.println("The provided word is not a palindrome");
                        return;
                    }
                }
                else {
                    System.out.println("The provided word is a palindrome");
                    return;
                }
            }
        }
    }
    
    //obtains user input of potential palindrome
    public static void obtainingPalindrome(){
        System.out.println("Type in the potential palindrome\n");
        input = in.nextLine();
        palindromeLength = input.length();
        splitInput = new String[palindromeLength];
        splitInput = input.split("");
        
        for (String s: splitInput){
           palindromeList.add(s);
        }
    }
    
}
