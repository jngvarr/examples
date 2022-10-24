int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23889;
int c2 = 33;
int a3 = 56;
int b3 = 23;
int c3 = 33;

// int max1=Max(a1, b1, c1);
// int max2=Max(a2, b2, c2);
// int max3=Max(a3, b3, c3);
// int max=Max(max1, max2, max3);

int max=Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));





// int max=a1;
// if (b1>max) b1=max;
// if (c1>max) c1=max;

// if (a2>max) a2=max;
// if (b2>max) b2=max;
// if (c2>max) c2=max;

// if (a3>max) a3=max;
// if (b3>max) b3=max;
// if (c3>max) c3=max;

Console.WriteLine(max);