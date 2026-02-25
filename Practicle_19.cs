using System;
class Menu
{
	static int r=15,rq1=0,pq1=0,cq1=0,p=180,c=30,rr=0,pr=0,cr=0;
	static int k,d=10;
	static int s=0,s11=0;
	static int s2=0,s22=0;
	static int s3=0,s33=0;
	static int rp=15;
	static int pp=180;
	static int cp=30;
	static void addroti()
	{
		Console.WriteLine("you choose for more roti:-");
		Console.Write("Quantity : ");
		rq1=int.Parse(Console.ReadLine());
		Console.Write("price : ");
		Console.WriteLine(r*rq1);
		s=((rq1*r)+s11);
		//s=s+s11;
		Console.WriteLine("Total = " + s);
	}
	static void addpaneertikka()
	{
		Console.WriteLine("you choose for more paneer tikka :-");
		Console.Write("Quantity : ");
		pq1=int.Parse(Console.ReadLine());
		Console.Write("price : ");
		Console.WriteLine(p*pq1);
		s2=((pq1*p)+s22);
		//s2=s2+s22;
		Console.WriteLine("Total = " + s2);
	}
	static void addchhash()
	{
		Console.WriteLine("you choose for more chhash:-");
		Console.Write("Quantity : ");
		cq1=int.Parse(Console.ReadLine());
		Console.Write("price : ");
		Console.WriteLine(c*cq1);
		s3=((cq1*c)+s33);
		//s3=s3+s33;
		Console.WriteLine("Total = " + s3);
	}
	static void Main()
	{
		int r=15,rq=0,p=180,pq=0,c=30,cq=0;
		char yn;	
		do
		{
			Console.WriteLine("Menu for hotel :-\n");
			Console.WriteLine("Press [1] for roti");
			Console.WriteLine("Press [2] for paneer tikka");
			Console.WriteLine("Press [3] for chhash\n");
			Console.Write("Your Choice : ");
			int choice = int.Parse(Console.ReadLine());
			
			switch(choice)
			{
				case 1:
					Console.WriteLine("you choose roti :-");
					Console.Write("Quantity : ");
					rq=int.Parse(Console.ReadLine());
					Console.Write("price : ");
					s11=r*rq;
					Console.WriteLine(s11);
					rr=(r*rq);
					Console.Write("Do you want to add more roti [y/n] : ");
					k=char.Parse(Console.ReadLine());
					if(k=='y')
					{
						//s11=0;
						addroti();
					}
					else
					{
					rr=0;
					s=((rq*rp)+rr);
					Console.WriteLine("Total = " + s);
					}
					break;
				case 2:
					Console.WriteLine("you choose paneer tikka :-");
					Console.Write("Quantity : ");
					pq=int.Parse(Console.ReadLine());
					Console.Write("price : ");
					s22=p*pq;
					Console.WriteLine(s22);
					pr=(p*pq);
					Console.Write("Do you want to add more paneer tikka [y/n] : ");
					k=char.Parse(Console.ReadLine());
					if(k=='y')
					{
						addpaneertikka();
					}
					else
					{
					pr=0;
					s2=((pq*pp)+pr);
					Console.WriteLine("Total = " + s2);
                    }
					break;
				case 3:
					Console.WriteLine("you choose chhash :-");
					Console.Write("Quantity : ");
					cq=int.Parse(Console.ReadLine());
					Console.Write("price : ");
					s33=c*cq;
					Console.WriteLine(s33);
					cr=(c*cq);
					Console.Write("Do you want to add more chhash [y/n] : ");
					k=char.Parse(Console.ReadLine());
					if(k=='y')
					{
						addchhash();
					}
					else
					{
					cr=0;
					s3=((cq*cp)+cr);
					Console.WriteLine("Total = " + s3);
                    }
					break;
			}
			Console.Write("Do you want to Continue Press [y/n] : ");
			yn = char.Parse(Console.ReadLine());
		}while(yn == 'y');
		int totalbill=s+(s11-rr)+s2+(s22-pr)+s3+(s33-cr);
		Console.WriteLine("Name:                              ");
		Console.WriteLine("Item                   qty.     Price     Amount");
		Console.WriteLine("Roti                    "+((s+s11-rr)/r)+"    "+"*"+"   "+rp+"    "+"="+"    "+(s+s11-rr));
		Console.WriteLine("paneer tikka            "+((s2+s22-pr)/p)+"    "+"*"+"   "+pp+"   "+"="+"    "+(s2+s22-pr));
		Console.WriteLine("chhash                  "+((s3+s33-cr)/c)+"    "+"*"+"   "+cp+"    "+"="+"    "+(s3+s33-cr));
		Console.WriteLine("                        ------------------------");
		Console.WriteLine("Grand Total                                 "+totalbill);
		if(totalbill>=1000)
		{
			totalbill-=(totalbill/d);
			Console.WriteLine("Your Total payeble Bill is : " + totalbill);
		}
	}
}
