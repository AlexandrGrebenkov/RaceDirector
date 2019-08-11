using RaceDirector.Services.TableParsers.Models;

namespace RaceDirector.Services.TableParsers
{
    /// <summary>
    /// Разбор строки таблицы результатов гонки, группы, квалификации
    /// </summary>
    public class RowParser
    {
        /// <summary>
        /// Разбор строки результата гонки
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public RowResult ParseRaceResult(params string[] input)
        {
            var result = new RowResult();
            result.Position = int.Parse(input[0]);
            result.FullName = input[1];
            result.Laps = int.Parse(input[2]);

            return result;
        }
    }
}
