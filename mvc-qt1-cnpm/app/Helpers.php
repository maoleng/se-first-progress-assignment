<?php

use Illuminate\Support\Facades\App;
use Illuminate\Support\Facades\Route;

if (!function_exists('c')) {
    function c(string $key)
    {
        return App::make($key);
    }
}

if (!function_exists('authed')) {
    function authed(): ?string
    {
        $token = session()->get('token');
        if (empty($token)) {
            return null;
        }
        $data = decrypt($token);
        if ($data !== 'admin-123456') {
            return null;
        }

        return 'admin';
    }
}

if (!function_exists('appendMenu')) {
    function appendMenu($route): string
    {
        return Route::currentRouteName() === $route ? 'active' : '';
    }
}

if (!function_exists('successAlert')) {
    function successAlert(): string
    {
        $message = session()->get('success');
        if ($message === null) {
            return '';
        }

        return "
            Swal.fire({
                icon: 'success',
                title: 'Successfully!',
                text: '$message',
                customClass: {
                    confirmButton: 'btn btn-success'
                }
            })
        ";
    }
}

if (!function_exists('errorAlert')) {
    function errorAlert(): string
    {
        $message = session()->get('error');
        if ($message === null) {
            return '';
        }

        return "
            Swal.fire({
                title: 'Error!',
                text: '$message',
                icon: 'error',
                customClass: {
                    confirmButton: 'btn btn-primary'
                },
                buttonsStyling: false
            })
        ";
    }
}
