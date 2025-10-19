/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        
        if (head == null || head.next == null)
            return head;

        int valorNodoAtual = head.val;
        int valorProximoNodo = head.next.val;
        int divisorComum = mdc(valorNodoAtual,valorProximoNodo);

        ListNode novoNodo = new ListNode(divisorComum);
        novoNodo.next = head.next;
        head.next = novoNodo;

        InsertGreatestCommonDivisors(head.next.next);
        return head;
    }

    private int mdc(int a, int b)
    {
        int maior = a >= b ? a : b;
        int divisor = b;

        while (a % divisor != 0 || b % divisor != 0)
            divisor--; 

        return divisor;           
    }
}