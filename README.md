# 📖Chapter 3-3 Unity 게임개발 심화주차 개인과제


### 🙋‍♂️ 11조 천홍

## 📅 개발 기간
2023.12.26 ~ 2023.12.29

## 💾 사용된 프로그램
Unity Engine 2022.3.2f

Visual Studio 2022(C#)

# 🎶 게임 ost 리듬게임

추억의 게임 ost로 진행하는 리듬게임입니다.  
예전에 많이 플레이 했었던 리듬게임들처럼 위에서 아래로 노트들이 내려오고  
타이밍에 맞춰서 키를 눌러 플레이합니다.

- **필수 구현 사항**
  - 시작화면 만들기


# 👍 핵심적인 기능

## 1. 편집 기능
![EditScene](https://github.com/hhhhhongg/HongRhythmGame/blob/main/ReadmeImages/%ED%8E%B8%EC%A7%91%EB%AA%A8%EB%93%9C.png)

게임을 시작하고 나서는 보이지 않는 씬입니다.  
원하는 노래 영상으로 Start Record를 할 수 있습니다.  
녹화 버튼을 누르게 되면 노래 영상이 시작되고 노래 리듬에 맞춰서 직접 노트를 찍을 수 있습니다.  
노트는 내가 누른 키값과 누른 시간에 대한 정보가 들어있고 이 노트들은 리스트로 저장을 합니다.  
녹화 중지버튼을 누르게되면 내가 지금까지 찍은 노트들에 대한 정보를 json 파일로 변환하여 텍스트로 저장할 수 있게하는 창이 뜹니다.  

## 2. 게임 시작 화면
![StartScene](https://github.com/hhhhhongg/HongRhythmGame/blob/main/ReadmeImages/%EA%B2%8C%EC%9E%84%20%EC%8B%9C%EC%9E%91%ED%99%94%EB%A9%B4.png)

게임을 시작했을때 화면입니다.  
Start버튼을 누르게 되면 곡 선택 화면으로 이동합니다.

## 3. 곡 선택 화면
![SongSelectScene](https://github.com/hhhhhongg/HongRhythmGame/blob/main/ReadmeImages/%EC%84%A0%EA%B3%A1%20%ED%99%94%EB%A9%B4.png)

내가 플레이하고 싶은 곡을 선택할 수 있는 화면입니다.    
앨범 표지를 누르고 Start를 누르게 되면 게임 플레이 화면으로 이동합니다.  

## 4. 게임 플레이 화면

![GamePlayScene](https://github.com/hhhhhongg/HongRhythmGame/blob/main/ReadmeImages/%EA%B2%8C%EC%9E%84%20%ED%94%8C%EB%A0%88%EC%9D%B4%20%ED%99%94%EB%A9%B4.png)

게임을 플레이하는 화면입니다.  
내가 선택한 곡으로 게임을 플레이 할 수 있습니다.  
노래는 싱크가 맞을 수 있도록 일정 시간 후에 플레이 됩니다. (싱크는 NoteSpanwer와 NoteHitter 사이의 거리를 통해 해결하였습니다.)  
컴퓨터키 S,D,F,J,K,L 로 플레이 할 수 있으며 키를 누르게되면 어떤 키를 눌렀는지 알 수 있게끔 라인의 색이 변했다가 돌아옵니다.  
Overlap 기능을 통해 노트가 일정 범위안에 들어와있는지 체크를 하고 범위에 따라 HitJudge 텍스트가 떴다가 사라집니다.

# 😢아직 구현하지 못한 내용 및 버그

### 1. Hit 판정 관련
  - Good, Great, Perfect는 뜨지만 설정해놓은 Bad,Miss 가 뜨지 않는 버그가 있습니다.

### 2. 싱크 관련
  - 게임 플레이를 할때마다 싱크가 매번 미세하게 다른 버그가 있습니다.

### 3. 점수 관련
  - 아직 게임을 플레이했을때 Score를 기록하는 기능을 구현하지 못했습니다.

### 4. 노래 리스트
  - 지금은 곡 하나만으로만 플레이 하고 있기 때문에 여러 곡들을 추가하고 싶습니다.





