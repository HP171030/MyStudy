﻿/*Data Struct
 * 
 * Generic                   NonGeneric                 용도                                                        Interface
 * 
 * List<T>                    Array,ArrayList     데이터가 저장된 순서를 빠르게 탐색함                                 IList
 * Dictionary<T>             HashTable           key로 빠르게 데이터를 조회할 때 사용/Key와 Value로 데이터가 저장됨     IDictionary
 * Queue<T>                  Queue               FIFO(선입선출) 방식으로 항목사용                                     ICollection
 * Stack<T>                  Stack               LIFO(후입선출) 방식으로 데이터 사용                                  ICollection
 * SortedList<TKey,TValue>   SortedList          입력된 순서와 상관없이 Key값으로 정렬됨                               IDictionary
 * LinkedList<T>                X                데이터 등록 삭제가 빈번하게 일어날 경우                               IList
 * ObservableCollection<T>      X                목록에 데이터를 넣거나 뺄때 알람을 표시                 
 * HashSet<T>,SortedSet<T>      X                중복된 데이터를 저장하지 않을때                                       ISet
 * 
 * 
 * List       장점 : 인덱스를 통해 빠르게 접근 가능, 동적 크기 조정 가능
 *            단점 : 중간에 요소를 추가하거나 삭제할때 성능 저하가 올 수 있음(O(n))
 *            - 한칸씩 모든 요소를 이동해야 하기 때문에 n의 시간복잡도
 *      
 * Dictionary 장점 : 0(1)의 시간복잡도로 키를 통한 빠른 조회 , 중복키를 허용하지 않음
 *            단점 : 메모리 사용량이 상대적으로 많을 수 있음
 *            - 해시 함수 의존성, 충돌 시 체이닝이나 오픈어드레싱을 통해 해결해야하는데 이 과정에서 성능 저하 가능성 있음
 *            - 클러스터링(Clustering) : 연속된 레코드에 데이터가 몰리는 현상
              - 오버플로우(Overflow) : 해시 충돌이 버킷에 할당된 슬롯 수보다 많이 발생하면 더 이상 버킷에 값을 넣을 수 없는 현상

              해시함수 특징
              
              1. 어떤 입력값에도 항상 고정된 길이의 해시값을 출력 (동일한 값이 입력되면 언제나 동일한 출력값을 보장)
              2. 눈사태 효과: 입력값의 아주 일부만 변경되어도 전혀 다른 결과 값을 출력
              3. 출력된 결과 값을 토대로 입력값을 유추할 수 없음
 *            
  
   Queue      장점 : 선입선출이 필요한 데이터의 흐름을 쉽게 관리할 수 있다.
              단점 : 중간 요소 접근 불가능


   Stack      장점 : 후입선출이 필요한 데이터의 흐름을 쉽게 관리할 수 있다.
 *            단점 : 중간 요소 접근 불가능
 *            
 *            
 * SortedList 장점 : 키로 자동 정렬되어 빠른 탐색 가능
 *            단점 : 삽입 시 성능 저하 가능(O(n))
 *            - 리스트와 같은 이유로 삽입,삭제시 성능 저하 가능성 있음
 * 
 * LinkedList 장점 : 노드를 추가하거나 삭제할 때 O(1)의 성능
 *            단점 : 인덱스를 통한 접근이 O(n)
 *            
 * ObservableCollection 장점 : 데이터 변경 시 이벤트 발생
 *                      단점 : 오버헤드로 인한 성능 저하
 *                      
 * HashSet 장점 : O(1)의 시간복잡도로 요소의 존재 여부 확인,중복 값을 허용하지 않음
 *         단점 : 순서 보장 X
 * 
 * SortedSet 장점 : 자동 정렬, 집한 연산 지원(교집합,합집합 등)
 *           단점 : 추가, 삭제 시 성능 저하 가능
 * 
 * 
 * 
 * 
 * 해시 충돌 처리 방법
 * 1. 체이닝
 *   각 슬롯이 링크드 리스트를 가지는 방식
 *   
 * 2. 오픈어드레싱
 *   충돌이 발생했을때 다음 슬롯을 탐색해서 비어있는 공간을 찾는 방식
 * - 선형 탐색 => 충돌 시 다음 인덱스 검색
 * - 이차 탐색 => 충돌 시 탐색 거리 제곱하여 탐색
 * - 더블 해싱 => 해시 함수를 두개 사용
 * 
 * 
 * 
 */
