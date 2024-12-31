public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        List<Tuple<int, int>> projects = new List<Tuple<int, int>>();
        for (int i = 0; i< profits.Length; i++) {
            projects.Add(new Tuple<int, int>(capital[i], profits[i]));
        }
        projects.Sort((x, y) => x.Item1.CompareTo(y.Item1));

        PriorityQueue<int, int> availableProjects = new PriorityQueue<int,int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        int currentCapital = w;
        int index = 0;

        for (int i = 0; i < k; i++) {
            while (index < projects.Count && projects[index].Item1 <= currentCapital) {
                availableProjects.Enqueue(projects[index].Item2, projects[index].Item2);
                index++;
            }
            if (availableProjects.Count == 0) break;

            int highestProfit = availableProjects.Dequeue();
            currentCapital += highestProfit;
        }
        return currentCapital;
    }
}