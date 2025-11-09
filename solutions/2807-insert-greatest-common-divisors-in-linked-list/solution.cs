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
    private int GCD(int a, int b){
        while(b!=0){
            a%=b;
            int temp = a;
            a = b ;
            b = temp;
        }
        return a ;
    }
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
         ListNode curr  = head;
         // dopki curr nie jest null oraz curr.next nie jest null to wykonujemy operacje
         while(curr !=null && curr.next !=null){
            // tworzymy nastepny node ktory jest najwiekszym wspolnym dzilenikie, a kolejny jest wartoscią next
            curr.next = new ListNode(GCD(curr.val,curr.next.val),curr.next);
            // (18) 6 (6) 2 (10) 1 (3)
            curr=curr.next.next;
         }
         return head;
    }
}