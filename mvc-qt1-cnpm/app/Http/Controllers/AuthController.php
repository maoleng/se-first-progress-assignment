<?php

namespace App\Http\Controllers;

use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;

class AuthController extends Controller
{

    public function login()
    {
        return view('login');
    }

    public function processLogin(Request $request)
    {
        $data = $request->all();
        if ($data['username'] === 'admin' && $data['password'] === '123456') {
            $token = encrypt($data['username'].'-'.$data['password']);
            session()->put('token', $token);
        }

        return redirect()->route('agent.index');
    }

    public function logout(): RedirectResponse
    {
        session()->forget('token');
        session()->flush();
        session()->save();

        return redirect()->route('index');
    }

}
