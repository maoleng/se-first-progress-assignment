<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Item extends Model
{
    use HasFactory;
    protected $table = 'item';
    protected $primaryKey = 'ItemID';
    public $timestamps = false;

    protected $fillable = [
        'ItemName', 'Size', 'Price',
    ];
}
