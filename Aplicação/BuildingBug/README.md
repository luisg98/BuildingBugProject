Building Bug - Android
===========================================

Summary
-------
Neste repositório podem encontrar uma aplicação de reparações e remodelações de casas que oferece uma série de benefícios significativos. Em primeiro lugar, simplifica o processo de encontrar profissionais qualificados e confiáveis para realizar trabalhos em casa, economizando tempo e evitando o stress de pesquisar por conta própria.
Além disso, uma aplicação desse tipo fornece estimativas de custos transparentes, permitindo aos proprietários planear os seus orçamentos de forma mais eficaz. Elas também podem melhorar a qualidade do trabalho, uma vez que muitas vezes incluem avaliações e comentários de outros utilizadores, permitindo aos clientes escolhas mais informadas.
Por fim, a conveniência de agendar serviços, receber atualizações em tempo real e acompanhar o progresso das reformas ou reparos torna a experiência mais eficiente e satisfatória para os proprietários.

# BuildingBug

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [Coding](#coding)
- [License](#license)

## Description

A aplicação trabalha juntamente com uma API e Base de Dados também desenvolvidas por nós (podem ser também encontradas neste repositório em pastas anteriores) e colocadas em servidores Microsoft Azure.
A aplicação é baseada em chamadas à API que contêm ou deveria conter todos os serviços relativos a regras de negócio.

![Login Screen](readme_assets/login_screen.png "Login Screen")
![clienteMenu Screen](readme_assets/clienteMenu_screen.png "clienteMenu Screen")
![proMenu Screen](readme_assets/proMenu_screen.png "proMenu Screen")
![novoServico](readme_assets/novoServico_screen.png "novoServico Screen")

## Funcionalidades



## Contribuir

Se queres contribuir com o BuildingBug, por favor segue estes passos:

Faz o fork do repositório.
Cria um novo ramo para a uma funcionalidade ou correção de erros.
Faça as suas alterações e submeta-as com mensagens claras.
Envie as suas alterações para o seu fork.
Envie um pull request, explicando as alterações que você fez.

## Coding

You can add mote sprites to this game by creating a class tha follows this pattern:

- `x` and `y` properties define the position of the sprite
- `bitmap` the visual representation
- `detectCollision` the area of collision with other sprites
- the `update(playerSpeed :Int)` function should calculate the position and the `detectCollision` of the sprite in the next frame sequence

```kotlin
class Enemy {
var bitmap : Bitmap

    var x = 0f
    var y = 0f
    var speed = 0
    var maxX = 0
    var maxY = 0

    val generator = Random()

    lateinit var detectCollision : Rect
    constructor(context: Context, width : Int, height:Int ) {
        maxY = height
        maxX = width

        bitmap = BitmapFactory.decodeResource(context.resources, R.drawable.enemy)
        x = maxX.toFloat()
        y = (generator.nextInt(maxY - bitmap.height) ).toFloat()
        speed = generator.nextInt(6) + 10

        detectCollision = Rect(x.toInt() ,y.toInt(), bitmap.width, bitmap.height)
    }

    fun update(playerSpeed :Int) {
        x -= playerSpeed
        x -= speed

        if (x < (0 - bitmap.width)){
            x = maxX.toFloat()
            y = (generator.nextInt(maxY - bitmap.height) ).toFloat()
            speed = generator.nextInt(6) + 10
        }

        detectCollision.left = x.toInt()
        detectCollision.top = y.toInt()
        detectCollision.right = x.toInt() + bitmap.width
        detectCollision.bottom = y.toInt() + bitmap.height
    }

}
```

- Than create an instance of Enemy on the class GameView and that should go through the update and draw function.

```kotlin
class GameView : SurfaceView, Runnable {
   //...
   val e: Enemy
   //...

   fun update() {
      //...
      e.update(player.speed)
      if (e.detectCollision.intersect(player.detectCollision)) {
         boom.x = e.x
         boom.y = e.y
      }

      //...
   }

   fun draw() {
      if (surfaceHolder.surface.isValid) {
         canvas = surfaceHolder.lockCanvas()
         canvas?.drawColor(Color.BLACK)
         //...
         canvas?.drawBitmap(e.bitmap, e.x, e.y, paint)
         //...
         surfaceHolder.unlockCanvasAndPost(canvas)
      }
   }

}
```

Discussion
----------

Sure there are many ways to develop games in Android, but this is the simpler and lighter way to do it. Have fun. 

License
-------

Copyright 2023 Lourenço Gomes

Licensed under [MIT License](LICENSE)