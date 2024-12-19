public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int totalGas = 0, tank = 0, start = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            int netGas = gas[i] - cost[i];
            totalGas += netGas;
            tank += netGas;

            
            if (tank < 0)
            {
                start = i + 1;
                tank = 0;
            }
        }

        
        return totalGas >= 0 ? start : -1;
    }
}
