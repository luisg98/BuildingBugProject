plugins {
    id("com.android.application")
    id("org.jetbrains.kotlin.android")

        kotlin("plugin.serialization") version "1.5.10"


}

android {

    namespace = "ipca.app.buildingbug"
    compileSdk = 34

    defaultConfig {
        applicationId = "ipca.app.buildingbug"
        minSdk = 26
        targetSdk = 33
        versionCode = 1
        versionName = "1.0"
        manifestPlaceholders["apiKey"] = "d68fe64649b74abc93522bb7972e5854"
        testInstrumentationRunner = "androidx.test.runner.AndroidJUnitRunner"
    }

    buildTypes {
        release {
            isMinifyEnabled = false
            proguardFiles(
                getDefaultProguardFile("proguard-android-optimize.txt"),
                "proguard-rules.pro"
            )
        }
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_1_8
        targetCompatibility = JavaVersion.VERSION_1_8
    }
    kotlinOptions {
        jvmTarget = "1.8"
    }

    buildFeatures {
        viewBinding = true
    }
}

dependencies {

    implementation("androidx.core:core-ktx:1.12.0")
    implementation("androidx.appcompat:appcompat:1.6.1")
    implementation("com.google.android.material:material:1.11.0")
    implementation("androidx.constraintlayout:constraintlayout:2.1.4")
    implementation(project(mapOf("path" to ":kotlin-client")))
    implementation(project(mapOf("path" to ":kotlin-client")))
    implementation(project(mapOf("path" to ":kotlin-client")))
    testImplementation("junit:junit:4.13.2")
    androidTestImplementation("androidx.test.ext:junit:1.1.5")
    androidTestImplementation("androidx.test.espresso:espresso-core:3.5.1")
    //BLUR
    implementation ("jp.wasabeef:glide-transformations:4.3.0")
    implementation ("com.github.bumptech.glide:glide:4.12.0")
    implementation ("com.google.code.gson:gson:2.8.9")
    implementation ("com.squareup.okhttp3:okhttp:4.11.0")

    // For LiveData
        implementation ("androidx.lifecycle:lifecycle-livedata-ktx:2.6.2")

        // For Kotlin coroutines
        implementation ("org.jetbrains.kotlinx:kotlinx-coroutines-android:1.6.4")
    implementation ("androidx.navigation:navigation-fragment-ktx:2.7.6")
    implementation ("androidx.navigation:navigation-ui-ktx:2.7.6")


        implementation("org.jetbrains.kotlinx:kotlinx-serialization-json:1.2.1")


    annotationProcessor ("com.github.bumptech.glide:compiler:4.12.0")

}