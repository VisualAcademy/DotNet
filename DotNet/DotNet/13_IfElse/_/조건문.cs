using System;
public class ���ǹ�{
	public static void ����(){
		int �Էµȼ��� = 9;
		//[1]if��
		if(�Էµȼ��� % 2 == 1){
			Console.WriteLine("{0}�� Ȧ���Դϴ�.", �Էµȼ���);
		}
		//[2]else��
		if(�Էµȼ��� % 2 == 0){
			Console.WriteLine("{0}�� ¦���Դϴ�.", �Էµȼ���);
		}
		else{
			Console.WriteLine("{0}�� Ȧ���Դϴ�.", �Էµȼ���);
		}
		//[3]else if��
		if(�Էµȼ��� % 3 == 0){
			Console.WriteLine("{0}�� 3�� ����Դϴ�.", �Էµȼ���);
		}
		else if(�Էµȼ��� % 4 == 0){
			Console.WriteLine("{0}�� 4�� ����Դϴ�.", �Էµȼ���);
		}
		else if(�Էµȼ��� % 5 == 0){
			Console.WriteLine("{0}�� 5�� ����Դϴ�.", �Էµȼ���);
		}
		else{
			Console.WriteLine(
				"{0}�� 3, 4, 5�� ����� �ƴմϴ�.", �Էµȼ���);
		}
	}
}
