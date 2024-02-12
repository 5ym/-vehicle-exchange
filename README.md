# vehicle-exchange

## dev

先に下記環境を構築しておいてください。  
<https://github.com/5ym/Local-Dev-Traefik>  

```sh
cp compose.sample.yml compose.yml
docker compose up
sudo chown -R $USER:$USER .
```

open <http://ve.localhost>

## 予定

- フロントワイヤーフレーム(shdcn-uiのパーツでfigamで作成) TOPのみでDone後は実装しながら
    - https://www.figma.com/file/oki49lValxojQUUKR44lRE/Untitled?type=whiteboard&t=yTJKVjMXVgEOOoc4-1
- フロント実装
- バックエンド実装
    - 認証系とかのやり方がわからん
- open-api codegenを利用してバックエンドのapiを自動でフロントライブラリ化
- 繋ぎこみ
    - 認証系とかのやり方がわからん
