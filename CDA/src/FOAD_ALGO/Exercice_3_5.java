package FOAD_ALGO;

import java.util.Scanner;

public class Exercice_3_5 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Entrer une cha�ne de caract�res finissant par un point ");
		String mot = sc.nextLine();
		sc.close();
		if (mot.equals(".")) {
			System.out.println("La phrase est vide");
		} else if (mot.endsWith(".")) {
			mot = mot.replaceAll(".", "").replaceAll(" ", "");
			String mot1 = new StringBuilder(mot).reverse().toString();
			if (mot.equals(mot1)) {
				System.out.println("la cha�ne de caract�res est un palindrome");
			} else {
				System.out.println("la cha�ne de caract�res n'est pas un palindrome");
			}
		} else {
			System.out.println("la cha�ne de caract�res ne contient pas de point");
		}
	}

}
