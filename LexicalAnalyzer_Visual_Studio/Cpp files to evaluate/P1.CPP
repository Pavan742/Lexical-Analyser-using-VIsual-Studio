#include<constream.h>
void main()
{
clrscr();
for(int i=1; i<=12; i++)
{
 for(int j=1; j<=12; j++)
 {
     if(i*j<=9)
     {
     cout<<"   ";
      }
      else if(i*j<=99)
      {
      cout<<"  ";
      }
      else
      {
      cout<<" ";
      }
    cout<<i*j;

 }
     cout<<endl;

}
getch();
}