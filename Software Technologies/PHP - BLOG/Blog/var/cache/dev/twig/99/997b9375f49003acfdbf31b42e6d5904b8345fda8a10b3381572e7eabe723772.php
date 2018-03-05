<?php

/* user/profile.html.twig */
class __TwigTemplate_d46cf778417a6a19f0d0c8875561685c4e0b11edaa93140f97901d3ea7d72081 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "user/profile.html.twig", 1);
        $this->blocks = array(
            'body_id' => array($this, 'block_body_id'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_917255a8a28be6e7dde775843f09547381a4488bfd007250fe12284d2ca019a5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_917255a8a28be6e7dde775843f09547381a4488bfd007250fe12284d2ca019a5->enter($__internal_917255a8a28be6e7dde775843f09547381a4488bfd007250fe12284d2ca019a5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "user/profile.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_917255a8a28be6e7dde775843f09547381a4488bfd007250fe12284d2ca019a5->leave($__internal_917255a8a28be6e7dde775843f09547381a4488bfd007250fe12284d2ca019a5_prof);

    }

    // line 3
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_27c7bac4370b7a57d44c9029789c8c2bb1a397e42fd8b6b0da1a33b09a594fc1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_27c7bac4370b7a57d44c9029789c8c2bb1a397e42fd8b6b0da1a33b09a594fc1->enter($__internal_27c7bac4370b7a57d44c9029789c8c2bb1a397e42fd8b6b0da1a33b09a594fc1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        echo "profile";
        
        $__internal_27c7bac4370b7a57d44c9029789c8c2bb1a397e42fd8b6b0da1a33b09a594fc1->leave($__internal_27c7bac4370b7a57d44c9029789c8c2bb1a397e42fd8b6b0da1a33b09a594fc1_prof);

    }

    // line 5
    public function block_main($context, array $blocks = array())
    {
        $__internal_955e7b26afb40468fb61542b61c6180f7a4ea0c473bd97d98efafc661dfe41ca = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_955e7b26afb40468fb61542b61c6180f7a4ea0c473bd97d98efafc661dfe41ca->enter($__internal_955e7b26afb40468fb61542b61c6180f7a4ea0c473bd97d98efafc661dfe41ca_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 6
        echo "    <div>
        ";
        // line 7
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["user"]) ? $context["user"] : $this->getContext($context, "user")), "email", array()), "html", null, true);
        echo "
        <br>
        ";
        // line 9
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["user"]) ? $context["user"] : $this->getContext($context, "user")), "fullName", array()), "html", null, true);
        echo "
    </div>
";
        
        $__internal_955e7b26afb40468fb61542b61c6180f7a4ea0c473bd97d98efafc661dfe41ca->leave($__internal_955e7b26afb40468fb61542b61c6180f7a4ea0c473bd97d98efafc661dfe41ca_prof);

    }

    public function getTemplateName()
    {
        return "user/profile.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  61 => 9,  56 => 7,  53 => 6,  47 => 5,  35 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends 'base.html.twig' %}

{% block body_id 'profile' %}

{% block main %}
    <div>
        {{ user.email }}
        <br>
        {{ user.fullName }}
    </div>
{% endblock %}
";
    }
}
