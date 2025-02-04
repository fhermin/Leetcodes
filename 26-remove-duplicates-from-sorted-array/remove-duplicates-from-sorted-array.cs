public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int writeIndex = 1; // Índice donde escribiremos los valores únicos
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[writeIndex] = nums[i];
                writeIndex++;
            }
        }

        return writeIndex; // Retorna la longitud del array sin duplicados
    }
}
