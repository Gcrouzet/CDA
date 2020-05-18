package FOAD_ALGO;

import java.util.Scanner;

public class Exercice_3_7 {

	public static void main(String[] args) {


		String[] tableau = { "agathe", "berthe", "chlo�", "cun�gonde", "olga", "raymonde", "sidonie" };

		String prenom = "";

		int min = 0, max = tableau.length - 1;
		int mid = (min + max) / 2;
		boolean present = false;

		Scanner sc = new Scanner(System.in);

		System.out.println("Saisir un pr�nom");
		prenom = sc.nextLine();

		while (present == false && min < max) {

			if (prenom.compareTo(tableau[mid]) == 0) { 
				present = true;
				break;

			} else if (prenom.compareTo(tableau[mid]) < 0) { 
				max = mid - 1;

			} else { 
				min = mid + 1;
			}
			mid = (min + max) / 2;
		}

		if (prenom.equals(tableau[mid])) {
			System.out.println("Pr�nom trouv� � la case n�" + (mid + 1));
		} else {
			System.out.println("Pr�nom non trouv�");
		}
		sc.close();
	}

}
