package  ipca.app.buildingbug
import android.Manifest
import android.content.Context
import android.content.pm.PackageManager
import android.location.Location
import android.location.LocationListener
import android.location.LocationManager
import android.os.Bundle
import androidx.core.content.ContextCompat

object LocationHelper {

    private var locationManager: LocationManager? = null
    private lateinit var locationResult: (Location?) -> Unit

    private val locationListener = object : LocationListener {
        override fun onLocationChanged(location: Location) {
            locationResult(location)
        }

        override fun onStatusChanged(provider: String?, status: Int, extras: Bundle?) {

        }

        override fun onProviderEnabled(provider: String) {

        }

        override fun onProviderDisabled(provider: String) {
            locationResult(null)
        }
    }
    fun getLocation(context: Context, result: (Location?) -> Unit) {
        this.locationResult = result
        if (ContextCompat.checkSelfPermission(context, Manifest.permission.ACCESS_FINE_LOCATION)
            != PackageManager.PERMISSION_GRANTED &&
            ContextCompat.checkSelfPermission(context, Manifest.permission.ACCESS_COARSE_LOCATION)
            != PackageManager.PERMISSION_GRANTED) {
            return
        }
        locationManager = context.getSystemService(Context.LOCATION_SERVICE) as LocationManager?

        // Solicitar atualizações de localização.
        locationManager?.requestLocationUpdates(LocationManager.NETWORK_PROVIDER, 0L, 0f, locationListener)
    }
    fun stopLocationUpdates() {
        locationManager?.removeUpdates(locationListener)
    }
}
