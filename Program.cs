class Program
{

    static void Main(string[] args)
    {
        int[,] map = {
            {0,0,1,0,0,0,0,0,0}, //Answer : 3 islands -> 16 - 3 - 1
            {0,1,1,1,1,0,0,1,1},
            {1,1,0,1,0,0,0,1,0},
            {0,1,0,0,1,0,0,0,0},
            {0,1,0,1,0,0,0,0,0},
            {0,1,1,1,1,0,0,0,0},
            {0,0,0,1,0,0,0,0,0}
        };

        int i, j,k,island_size = 0;

        
        List<Cordinate> all_cordinates = new List<Cordinate>();
        List<int> islands_size = new List<int>();
        
        for (i = 0; i < map.GetLength(0); i++)//7
        {
            for (j = 0; j < map.GetLength(1); j++)//9
            {
              Console.Write(map[i,j]==0?" ":"▯");
                if (map[i, j] == 1)
                {
                    island_size = islandSize(j,i);
                    if(island_size>0)
                        islands_size.Add(island_size);
                }
            }
            Console.WriteLine("");
        }

        Console.Write("Islands:");
        for(i=0;i<islands_size.Count;i++)
            Console.Write($" {islands_size[i]} ");


        
        int islandSize(int x,int y){
            if (x>=0 && y>=0 && x<map.GetLength(1) && y<map.GetLength(0) && map[y, x] == 1)
            {
                for (k = 0; k < all_cordinates.Count; k++)
                {
                    if (x == all_cordinates[k].x_cord && y == all_cordinates[k].y_cord)
                        return 0;

                }

                //if not found
                Cordinate cordinate_temp = new Cordinate();
                cordinate_temp.x_cord = x;
                cordinate_temp.y_cord = y;
                all_cordinates.Add(cordinate_temp);
                
                return 1 + islandSize(x, y + 1) + islandSize(x, y - 1) + islandSize(x + 1, y) + islandSize(x - 1, y);

            }
            return 0;
        }

        //Console.WriteLine(islandSize(0,2));

    }

}

public class Cordinate
{
    public int x_cord, y_cord;
}