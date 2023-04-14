<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Agent extends Model
{
    use HasFactory;
    protected $table = 'agent';
    protected $primaryKey = 'AgentID';
    public $timestamps = false;

    protected $fillable = [
        'AgentName', 'Address',
    ];
}
