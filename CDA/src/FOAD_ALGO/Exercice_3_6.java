package FOAD_ALGO;

import java.util.Scanner;

public class Exercice_3_6 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		boolean present = false;
		int tentative = 6;
		boolean end = false;

		System.out.println("Joueur 1 : Proposez un mot (min 5 caract�res !) :");
		String mot = sc.nextLine();

		if (mot.length() >= 5) {

			char[] devine = mot.toCharArray();
			for (int i = 0; i < devine.length; i++) {
				devine[i] = '_';
			}
			devine[0] = mot.charAt(0);
			int last = mot.length() - 1;
			devine[last] = mot.charAt(last);
			for (int i = 0; i < devine.length; i++) {
				System.out.print(devine[i] + " ");
			}
			System.out.println();
			while (tentative > 0 && end == false) {

				System.out.println("\n" + "Joueur 2 : Saisir une lettre");

				String saisie = sc.next();

				if (saisie.length() > 1) {
					System.out.println("UNE lettre, pas plus ;)");
				} else {

					char lettre = saisie.charAt(0);

					for (int i = 0; i < devine.length; i++) {

						if (mot.charAt(i) == lettre) {
							devine[i] = lettre;
							present = true;
						}
					}
					if (present == true) {
						System.out.println("Lettre pr�sente");
					} else {
						System.out.println("Lettre non pr�sente");
						tentative--;
						System.out.println(tentative + " tentative(s) restante(s)");
					}
					for (int i = 0; i < devine.length; i++) {
						System.out.print(devine[i] + " ");
					}
					System.out.println();

					for (int i = 0; i < devine.length; i++) {
						if (devine[i] == '_') {
							end = false;
							break;
						} else {
							end = true;
						}
					}
					present = false;
				}
			}

			if (tentative == 0 || end == true) {
				if (tentative == 0) {
					System.out.println("DEFAITE");
					System.out.println("Le mot �tait : " + mot);
				}
				if (tentative > 0 && end == true) {
					System.out.println("VICTOIRE");
				}
			}
		} else {
			System.out.println("Ce mot fait moins de 5 caract�res");
		}
		sc.close();
	}
}
