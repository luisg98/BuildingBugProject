package ipca.app.buildingbug

import android.content.Intent
import android.os.Bundle
import android.os.Handler
import android.os.Looper
import android.widget.ImageView
import androidx.appcompat.app.AppCompatActivity

class SplashScreenActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_splash_screen)

        val myImageView: ImageView = findViewById(R.id.SplashScreenImageView)
        myImageView.setImageResource(R.drawable.image1)


        Handler(Looper.getMainLooper()).postDelayed({
                val i = Intent(this, LoginActivity::class.java)
                startActivity(i)
                finish()
        }, 3000)
    }
}