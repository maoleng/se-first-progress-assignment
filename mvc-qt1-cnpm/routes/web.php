<?php

use App\Http\Controllers\AgentController;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\FilterController;
use App\Http\Controllers\ItemController;
use App\Http\Controllers\OrderController;
use App\Http\Middleware\AuthAdmin;
use App\Http\Middleware\IfAlreadyLogin;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/
Route::get('/', function () {
    if (authed() === null) {
        return redirect()->route('login_view');
    }

    return redirect()->route('agent.index');
});

Route::group(['middleware' => [IfAlreadyLogin::class]], static function () {
    Route::get('/login', [AuthController::class, 'login'])->name('login_view');
    Route::post('/login', [AuthController::class, 'processLogin'])->name('process_login');
});
Route::get('/logout', [AuthController::class, 'logout'])->name('logout');

Route::group(['middleware' => [AuthAdmin::class]], static function () {
    Route::group(['prefix' => 'agent', 'as' => 'agent.'], static function () {
        Route::get('/', [AgentController::class, 'index'])->name('index');
        Route::post('/', [AgentController::class, 'store'])->name('store');
    });
    Route::group(['prefix' => 'item', 'as' => 'item.'], static function () {
        Route::get('/', [ItemController::class, 'index'])->name('index');
        Route::post('/', [ItemController::class, 'store'])->name('store');
    });
    Route::group(['prefix' => 'order', 'as' => 'order.'], static function () {
        Route::get('/', [OrderController::class, 'index'])->name('index');
    });
    Route::group(['prefix' => 'filter', 'as' => 'filter.'], static function () {
        Route::get('/', [FilterController::class, 'index'])->name('index');
    });
});

Route::get('/toggle_dark_mode', static function () {
    session()->put('dark_mode', ! session()->get('dark_mode'));
})->name('toggle_dark_mode');
