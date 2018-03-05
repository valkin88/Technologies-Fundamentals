<?php

/* form/fields.html.twig */
class __TwigTemplate_ced23972b6fb842d58e8fe8c3dcd522f036da49048efea49ea583bfc2f508623 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'date_time_picker_widget' => array($this, 'block_date_time_picker_widget'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_865dba952bae413e655f189338c93d470437576aa161a951c272ad4774e6d49f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_865dba952bae413e655f189338c93d470437576aa161a951c272ad4774e6d49f->enter($__internal_865dba952bae413e655f189338c93d470437576aa161a951c272ad4774e6d49f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "form/fields.html.twig"));

        // line 9
        echo "
";
        // line 10
        $this->displayBlock('date_time_picker_widget', $context, $blocks);
        
        $__internal_865dba952bae413e655f189338c93d470437576aa161a951c272ad4774e6d49f->leave($__internal_865dba952bae413e655f189338c93d470437576aa161a951c272ad4774e6d49f_prof);

    }

    public function block_date_time_picker_widget($context, array $blocks = array())
    {
        $__internal_8603b5cee91d341de60c8c1bd426a32f50e049e71a310929c4d4a677a6c33fad = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8603b5cee91d341de60c8c1bd426a32f50e049e71a310929c4d4a677a6c33fad->enter($__internal_8603b5cee91d341de60c8c1bd426a32f50e049e71a310929c4d4a677a6c33fad_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "date_time_picker_widget"));

        // line 11
        echo "    ";
        ob_start();
        // line 12
        echo "        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            ";
        // line 13
        $this->displayBlock("datetime_widget", $context, $blocks);
        echo "
            ";
        // line 15
        echo "                ";
        // line 16
        echo "            ";
        // line 17
        echo "        </div>
    ";
        echo trim(preg_replace('/>\s+</', '><', ob_get_clean()));
        
        $__internal_8603b5cee91d341de60c8c1bd426a32f50e049e71a310929c4d4a677a6c33fad->leave($__internal_8603b5cee91d341de60c8c1bd426a32f50e049e71a310929c4d4a677a6c33fad_prof);

    }

    public function getTemplateName()
    {
        return "form/fields.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  52 => 17,  50 => 16,  48 => 15,  44 => 13,  41 => 12,  38 => 11,  26 => 10,  23 => 9,);
    }

    public function getSource()
    {
        return "{#
   Each field type is rendered by a template fragment, which is determined
   by the name of your form type class (DateTimePickerType -> date_time_picker)
   and the suffix \"_widget\". This can be controlled by overriding getBlockPrefix()
   in DateTimePickerType.

   See http://symfony.com/doc/current/cookbook/form/create_custom_field_type.html#creating-a-template-for-the-field
#}

{% block date_time_picker_widget %}
    {% spaceless %}
        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            {{ block('datetime_widget') }}
            {#<span class=\"input-group-addon\">#}
                {#<span class=\"fa fa-calendar\" aria-hidden=\"true\"></span>#}
            {#</span>#}
        </div>
    {% endspaceless %}
{% endblock %}
";
    }
}
