package lab71;

import java.util.ArrayList;
import java.util.List;
import java.util.HashSet;

public class Lab71 {

	public static void main(String []args){
		String text = new String("ddafdc oasap fdasd dd ss as fdppd sda. ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda."
				+ "ddafdc oasap fdasd as fdppd sda. " + '\n');
		
		System.out.print(text);
		String Sentences[] = text.split("[.!?]\\s*");
		
		HashSet<String> words = new HashSet<String>();
		String[] first = Sentences[0].split(" ");
		
		for (String s: first) {
			words.add(s);
		}
	
		for(int i = 1; i < Sentences.length;i++) {
			String[] Sentence = Sentences[i].split(" ");
				for(int j = 0; j < Sentence.length;j++) {
					if ( words.contains(Sentence[j])) {
						words.remove(Sentence[j]);
					}
			}
		}
		System.out.println(words);
	}
}

