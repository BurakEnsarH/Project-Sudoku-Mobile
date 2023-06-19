using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SudokuEasyData : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();

        data.Add(new SudokuData.SudokuBoardData(

            new int[81] {0, 1, 4, 0, 0, 0, 0, 3, 0, 3, 0, 0, 5, 1, 0, 8, 0, 0, 0, 8, 0, 0, 0, 9, 0, 0, 6, 0, 0, 1, 8, 0, 0, 6, 0, 0, 0, 0, 3, 2,
            5, 6, 4, 0, 0, 0, 0, 6, 0, 0, 7, 2, 0, 0, 9, 0, 0, 7, 0, 0, 0, 4, 0, 0, 0, 5, 0, 8, 4, 0, 0, 2, 0, 4, 0, 0, 0, 0, 7, 1, 0, },

            new int[81] { 2, 1, 4, 6, 7, 8, 9, 3, 5, 3, 6, 9, 5, 1, 2, 8, 7, 4, 5, 8, 7, 4, 3, 9, 1, 2, 6, 4, 2, 1, 8, 9, 3, 6, 5, 7, 7, 9, 3, 2,
            5, 6, 4, 8, 1, 8, 5, 6, 1, 4, 7, 2, 9, 3, 9, 3, 2, 7, 6, 1, 5, 4, 8, 1, 7, 5, 9, 8, 4, 3, 6, 2, 6, 4, 8, 3, 2, 5, 7, 1, 9,}));

        return data;
    }
}

public class SudokuMediumData : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();

        data.Add(new SudokuData.SudokuBoardData(

            new int[81] {0, 1, 4, 0, 0, 0, 0, 3, 0, 3, 0, 0, 5, 1, 0, 8, 0, 0, 0, 8, 0, 0, 0, 9, 0, 0, 6, 0, 0, 1, 8, 0, 0, 6, 0, 0, 0, 0, 3, 2,
            5, 6, 4, 0, 0, 0, 0, 6, 0, 0, 7, 2, 0, 0, 9, 0, 0, 7, 0, 0, 0, 4, 0, 0, 0, 5, 0, 8, 4, 0, 0, 2, 0, 4, 0, 0, 0, 0, 7, 1, 0, },

            new int[81] { 2, 1, 4, 6, 7, 8, 9, 3, 5, 3, 6, 9, 5, 1, 2, 8, 7, 4, 5, 8, 7, 4, 3, 9, 1, 2, 6, 4, 2, 1, 8, 9, 3, 6, 5, 7, 7, 9, 3, 2,
            5, 6, 4, 8, 1, 8, 5, 6, 1, 4, 7, 2, 9, 3, 9, 3, 2, 7, 6, 1, 5, 4, 8, 1, 7, 5, 9, 8, 4, 3, 6, 2, 6, 4, 8, 3, 2, 5, 7, 1, 9,}));

        return data;
    }
}

public class SudokuHardData : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();

        data.Add(new SudokuData.SudokuBoardData(

            new int[81] {0, 1, 4, 0, 0, 0, 0, 3, 0, 3, 0, 0, 5, 1, 0, 8, 0, 0, 0, 8, 0, 0, 0, 9, 0, 0, 6, 0, 0, 1, 8, 0, 0, 6, 0, 0, 0, 0, 3, 2,
            5, 6, 4, 0, 0, 0, 0, 6, 0, 0, 7, 2, 0, 0, 9, 0, 0, 7, 0, 0, 0, 4, 0, 0, 0, 5, 0, 8, 4, 0, 0, 2, 0, 4, 0, 0, 0, 0, 7, 1, 0, },

            new int[81] { 2, 1, 4, 6, 7, 8, 9, 3, 5, 3, 6, 9, 5, 1, 2, 8, 7, 4, 5, 8, 7, 4, 3, 9, 1, 2, 6, 4, 2, 1, 8, 9, 3, 6, 5, 7, 7, 9, 3, 2,
            5, 6, 4, 8, 1, 8, 5, 6, 1, 4, 7, 2, 9, 3, 9, 3, 2, 7, 6, 1, 5, 4, 8, 1, 7, 5, 9, 8, 4, 3, 6, 2, 6, 4, 8, 3, 2, 5, 7, 1, 9,}));

        return data;
    }
}

public class SudokuVeryHardData : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();

        data.Add(new SudokuData.SudokuBoardData(

            new int[81] {0, 1, 4, 0, 0, 0, 0, 3, 0, 3, 0, 0, 5, 1, 0, 8, 0, 0, 0, 8, 0, 0, 0, 9, 0, 0, 6, 0, 0, 1, 8, 0, 0, 6, 0, 0, 0, 0, 3, 2,
            5, 6, 4, 0, 0, 0, 0, 6, 0, 0, 7, 2, 0, 0, 9, 0, 0, 7, 0, 0, 0, 4, 0, 0, 0, 5, 0, 8, 4, 0, 0, 2, 0, 4, 0, 0, 0, 0, 7, 1, 0, },

            new int[81] { 2, 1, 4, 6, 7, 8, 9, 3, 5, 3, 6, 9, 5, 1, 2, 8, 7, 4, 5, 8, 7, 4, 3, 9, 1, 2, 6, 4, 2, 1, 8, 9, 3, 6, 5, 7, 7, 9, 3, 2,
            5, 6, 4, 8, 1, 8, 5, 6, 1, 4, 7, 2, 9, 3, 9, 3, 2, 7, 6, 1, 5, 4, 8, 1, 7, 5, 9, 8, 4, 3, 6, 2, 6, 4, 8, 3, 2, 5, 7, 1, 9,}));

        return data;
    }
}

public class SudokuData : MonoBehaviour
{
    public static SudokuData Instance;

    public struct SudokuBoardData
    {
        public int[] unsolved_data;
        public int[] solved_data;

        public SudokuBoardData(int[] unsolved, int[] solved) : this()
        {
            this.unsolved_data = unsolved;
            this.solved_data = solved;
        }
    };

    public Dictionary<string, List<SudokuBoardData>> sudoku_game = new Dictionary<string, List<SudokuBoardData>> ();

    void Awake ()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    } 


    void Start()
    {
        sudoku_game.Add("Easy", SudokuEasyData.getData());
        sudoku_game.Add("Medium", SudokuEasyData.getData());
        sudoku_game.Add("Hard", SudokuEasyData.getData());
        sudoku_game.Add("VeryHard", SudokuEasyData.getData());
    }

}
