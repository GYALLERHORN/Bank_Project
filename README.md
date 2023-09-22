# Bank_Project

</br>

## 프로젝트 작성자

김진성

</br>

## 구현한 과제

ATM시스템 만들기

</br>

## 구현 내용

![image](https://github.com/GYALLERHORN/Bank_Project/assets/141597722/02154e95-87c6-4128-84e0-13cbca1b51ea)</br>
사용자 이름(Name), 현금(Cash), 계좌 잔액(Account)를 좌측 텍스트로, 입금(DEPOSIT)&출금(WITHDRAW) 기능을 우측 버튼으로 구현했습니다.

</br>

![image](https://github.com/GYALLERHORN/Bank_Project/assets/141597722/1f4ab43c-14bb-41ca-ac58-60a4995a43c6)</br>
![image](https://github.com/GYALLERHORN/Bank_Project/assets/141597722/ba3748e7-9b83-461c-ab94-4d094458aff0)</br>

 - 입금(혹은 출금)버튼 클릭 시 위와 같이 거래 UI가 활성화되고, 금액버튼(1)을 누르거나 직접 입력으로 거래금액(3)에 내용을 입력할 수 있고, CLEAR버튼(2) 클릭으로 (3)을 0으로 초기화할 수 있습니다.
 - 금액 입력 후 확인 버튼(4) 클릭 시 (3)만큼 거래가 실행됩니다. 입금UI 에서 거래 실행 시 현금-거래금액, 계좌잔액+거래금액이 실행, 출금UI 에서 거래 실행 시 계좌잔액-거래금액, 현금+거래금액이 실행됩니다.
 - (3)에는 숫자만 입력할 수 있습니다.
 - 거래 실행 후 (3)은 0으로 초기화됩니다.
 - 입금 시 (3)이 현금보다 클 경우(또는 출금 시 (3)이 계좌잔액보다 클 경우), 거래 실패 UI(6)((7))가 표시됩니다. 거래 실패 UI는 클릭 시 비활성화됩니다.
 - 취소 버튼(5) 클릭 시 거래 UI가 비활성화됩니다.
