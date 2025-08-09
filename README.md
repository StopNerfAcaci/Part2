Task 1: Replace image from Resources/prefabs
Task 2: Complete 1,2,3,4
Task 3: Complete 1,2
 GameSetting.cs:  Add checkCellSize and matchLimit, checkCellSize is the number of cell in bottom area, the cell will be destroyed when reach matchLimit
 Board.cs: 
 - Create another cell list named checkCells as container for fish in the bottom area and generate them in createBoard()
 - Change the logic in fill() to fit the new gameplay.
 - New main function:
  + GenerateValidBoard(int total) which used to calculate the quantity of each fish type then create them on the screen.
  + AssignToMatchCell() that will be called in BoardController.cs to select a fish and move them to bottom area. This will trigger everytime mouse down
  + IsCheckFull() check if the bottom area is full or not
  + IsClearBoard() check if the board is clear or not
  + GetMatches() check the bottom are whether they have 3 similar fish. If yes destroy those fish. This will trigger everytime mouse up

BoardController.cs:
 - Turn off hint system
 - mouse down now perform AssignToMatchCell() function
 - mouse up now perform into GetMatches() function
 - Turn off (mouse down and isDragging)
 - New function:
   + bool IsWinGame check board.IsClearBoard()
   + bool IsLoseGame check board.IsCheckFull()
GameManager.cs:
 - Add a bool isWin to check if it is win or not
 - Move eLevelMode into public enum and add 'MATCH' as an element for new gameplay
 - - Adject LoadLevel() in GameManager to change into new gameplay
Create new script: LevelMatch.cs for new gameplay
  - Add delegate OnMatchEvent in Board.cs to call into this script everytime mouse up to check the win and lose condition.
UIPanelMain.cs:
 - Add a SerializeField for eLevelMode to change gameplay type in inspector
UIPanelGameOver.cs:
 - Add a SerializeField for Text to change the text whether player win or lose
   
