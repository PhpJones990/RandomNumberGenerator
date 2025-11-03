using System;
using System.Numerics;

public delegate ulong RNG();

public class Algorithms
{
	public static int seed = 0;
	public static ulong state = 0;
	public Algorithms()
	{

	}

	public static void seed_update()
	{
		seed = Convert.ToInt32((state % Convert.ToUInt64(99999)));
    }

	public static int wrapper_func(RNG algo)
	{
		return number_wrapping(0, 9, algo());
    }

	public static int number_wrapping(int low, int high, ulong value)
	{
		int scaled_number = Convert.ToInt32(Convert.ToUInt64(low) + (value % Convert.ToUInt64(high - low + 1)));
		return scaled_number;
	}

	public static ulong xorshift()
	{
		if (seed != -1) state = Convert.ToUInt64(seed);
		seed = -1;

		ulong x = state;
		x ^= (x << 13);
		x ^= (x >> 7);
		x ^= (x << 17);
		state = x;
		return state;
	}
}
